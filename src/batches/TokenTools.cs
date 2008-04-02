using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter support pair into a bucket.</summary>
        public static long GradeFilterSupport(long target, long bound)
        {
            if ((target - bound) != (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((bound % 60) == (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if (((bound ^ bound) >= (bound + (-366))) && ((bound ^ 97) < (bound ^ 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((target & 1) > target)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
