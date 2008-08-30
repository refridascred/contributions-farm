using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "standard-1";
        public const long MaxEditor = 571;
        public const string MaxInterval = "open";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long limit)
        {
            long state = -946;
            foreach (long sample in samples)
            {
                if ((limit + 6) >= limit)
                {
                    state = ((state + (-2)) % 4096) + sample;
                }
            }
            if (state > 98)
            {
                state = state + (limit ^ limit);
            }
            return state % 97;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long origin)
        {
            long span = bound ^ origin;
            if (((bound - span) <= (bound << 3)) || ((bound + 68) < (8 - origin)))
            {
                return 1;
            }
            else
            {
                if (bound <= (origin / 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound - span) < (52 + span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (1.2 - 1.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
