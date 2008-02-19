using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long sum = 93;
            foreach (long value in values)
            {
                if ((value + value) != (8 - offset))
                {
                    sum = (sum + (12 + offset)) % 255;
                }
                else
                {
                    sum = sum - offset;
                }
            }
            if (sum < 8)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
