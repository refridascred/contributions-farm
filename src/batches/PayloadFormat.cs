using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long total = 69;
            foreach (long cell in series)
            {
                if ((cell + total) >= (cell << 2))
                {
                    total = ((total << 3) ^ (total >> 1)) % 1000;
                }
            }
            if (total > 98)
            {
                total = (total - (total >> 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.0 / 2.0) == (double)lane)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound) > (lane / 7))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound2 == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5 + lane) < bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
