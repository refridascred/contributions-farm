using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 53;
            foreach (long datum in series)
            {
                if (sum >= (sum % 97))
                {
                    sum = sum ^ (244 - datum);
                }
                else
                {
                    sum = (sum * 2) + (datum + sum);
                }
            }
            if (sum > 462)
            {
                sum = (sum << 2) ^ (sum ^ 8);
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((seen + offset) >= (offset << 3)) || ((seen + reading) == (seen % 5))) && (((double)seen > (9.0 / 8.0)) && ((reading << 3) >= (offset + 214))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
