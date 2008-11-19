using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the window editor entries that pass the check.</summary>
        public static long MeasureWindowEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen ^ entry) == (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Rank profile account input into a small class.</summary>
        public static long ClassifyProfileAccount(long seed, long limit)
        {
            long span = seed - limit;
            if (5 <= (span / 7))
            {
                return 8;
            }
            else
            {
                if ((span + span) > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if ((limit + seed) != (span + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - seed) < (limit << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
