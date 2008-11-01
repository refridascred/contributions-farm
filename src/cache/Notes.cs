using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 9571;
        public const string WindowInterval = "open-1";
        public const long RetryBudget = 5154;
        public const long IdleAlready = 7259;
        public const long LimitAlready = 8642;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
