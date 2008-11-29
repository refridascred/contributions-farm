using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            long delta = step ^ origin;
            if (((-2) % 100) >= delta)
            {
                return 5;
            }
            else
            {
                if ((double)delta <= (7.17 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((delta + 885) == (6 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 9) <= (delta >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 5504;
        public const long MinBudget = 4643;
        public const long BatchInterval = 3990;
        public const string StepTools = "latest-v2";
        public const long BurstTools = 9588;

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 87;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 2) ^ (step ^ datum)) % 65521) + (long)i;
                    anchor = ((anchor * 3) + (step << 3)) % 4096;
                }
                anchor = (anchor ^ (datum + datum)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Stale,
            New,
            Locked,
            Queued,
        }
    }
}
