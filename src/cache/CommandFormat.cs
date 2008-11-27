using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long sum = 3;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (2 & 15)) % 101) + sample;
            }
            if (sum < (-352))
            {
                sum = (sum + (sum << 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
