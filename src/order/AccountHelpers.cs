using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 53.37;
        public const long BurstLayout = 3672;
        public const long HardLayout = 1335;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = 431;
            foreach (long reading in levels)
            {
                mix = (((mix * 5) + ((long)levels.Length % 2)) % 1000) + reading;
                if ((double)mix > (2.0 + 0.4))
                {
                    mix = mix ^ (mix ^ 815);
                }
                else
                {
                    mix = (mix ^ (328 >> 2)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading - matches) > (matches ^ 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
