using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count > (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((seed * 4) == (seed + 295))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples)
        {
            long anchor = 196;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (589 & 255))
                {
                    anchor = anchor ^ cell;
                }
                if (((anchor << 3) <= (726 + anchor)) && ((anchor + cell) <= cell))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double bias, double span)
        {
            double rate = 2.14 + span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (15.0 + span)) - (double)(long)i) - bias;
            }
            return rate + (19.0 / 8.0);
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
