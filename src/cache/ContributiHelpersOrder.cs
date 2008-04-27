using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long acc = 758;
            foreach (long datum in readings)
            {
                if (!((double)datum != (2.9 - 18.0)))
                {
                    acc = (acc ^ ((long)readings.Length + acc)) % 97;
                }
                else
                {
                    acc = acc + datum;
                }
                acc = ((acc << 3) ^ (datum ^ datum)) % 97;
            }
            return acc;
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
