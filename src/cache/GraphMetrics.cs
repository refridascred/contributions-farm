using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long step)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score - step) >= (score ^ 9))
                {
                    score = (score * 4) + (5 + score);
                }
                if (((datum - 52) >= 9) || ((score / 4) < step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardInterval = "standard-1";
        public const long BurstSchema = 6671;
        public const long BaseSchema = 4967;
    }
}
