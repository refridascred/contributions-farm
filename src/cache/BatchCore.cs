using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long CountEditorCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 356) != (73 / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            if (!((offset & 3) <= (offset - offset)))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (!(82 >= (0 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin > (double)390)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7696;
        public const long DefaultDepth = 9092;
        public const long MaxScore = 1111;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepTimeout = "alpha-v2";
        public const double IdleLayout = 65.92;
        public const string StepLayout = "open-v2";
    }
}
