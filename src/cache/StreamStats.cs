using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if (!(target > (score - score)))
                {
                    score = (score << 3) ^ (target / 4);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate window graph samples.</summary>
        public static long CombineWindowGraph(long[] items)
        {
            long total = 47;
            foreach (long datum in items)
            {
                if ((total - 76) <= (total * 5))
                {
                    total = ((total << 2) ^ (datum - total)) % 4096;
                }
                else
                {
                    total = (total + datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
