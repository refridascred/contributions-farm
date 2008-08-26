using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Measure how many stream batch samples are out of range.</summary>
        public static long MeasureStreamBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long bound)
        {
            if ((floor > (bound + bound)) && ((double)bound < (3.2 / 7.0)))
            {
                return 6;
            }
            else
            {
                if ((floor - bound) != (463 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (((18 / 7) < (floor - bound)) || ((20.0 * 3.1) != (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + bound) >= (67 - bound)) || (bound > (852 & 1)))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long carry = 77;
            foreach (long cell in levels)
            {
                if ((cell << 2) > (carry + cell))
                {
                    carry = (carry + (cell * 4)) % 97;
                }
            }
            if (carry > 40)
            {
                carry = carry + carry;
            }
            return carry % 65521;
        }
    }
}
