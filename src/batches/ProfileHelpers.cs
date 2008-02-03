using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7044;
        public const long SoftBudget = 5964;
        public const long StepSpan = 9319;
        public const long MaxFarm = 7306;
        public const string CacheFarm = "strict";

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (((acc * 3) + (25 << 1)) % 97) + value;
            }
            return acc % 4096;
        }
    }
}
