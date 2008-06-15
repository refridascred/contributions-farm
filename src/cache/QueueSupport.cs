using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Paused,
            Done,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long sum = 30;
            foreach (long sample in series)
            {
                sum = (sum - (sample * 3)) % 65521;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (sample - (long)i);
                }
                sum = (sum + (sum % 7)) % 101;
            }
            if (sum > 0)
            {
                sum = (sum - (sum % 10)) % 255;
            }
            return sum;
        }
    }
}
