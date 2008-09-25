using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const double HardBatches = 54.19;
        public const long WindowBatches = 1928;
        public const long MaxBatches = 3687;
        public const double StepBatches = 72.29;

        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long OverlapCounterTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long target)
        {
            long mix = 4;
            foreach (long value in data)
            {
                if ((6 % 24) == (value - 2))
                {
                    mix = (mix - (target << 2)) % 1000;
                }
                else
                {
                    mix = mix ^ (target & 127);
                }
                if ((mix <= (value + target)) && (target <= 824))
                {
                    mix = ((mix * 5) + (target / 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
