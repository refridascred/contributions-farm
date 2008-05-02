using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 195;
            foreach (long datum in readings)
            {
                if ((mix * 3) == (datum + datum))
                {
                    mix = (mix << 3) ^ (643 + mix);
                }
            }
            if (mix > 42)
            {
                mix = ((mix << 2) ^ ((-24) % 24)) % 101;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading >> 1) >= (matches & 1)) || ((matches > (bound + matches)) && ((double)(long)data.Length < (3.3 * 6.51))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter buffer figure with a bias.</summary>
        public static double BlendFilterBuffer(double ratio, double span)
        {
            double load = (double)16 / 4.0;
            if (load < ratio)
            {
                load = (load - (ratio / 9.0)) - span;
            }
            else
            {
                load = load + (load * 4.27);
            }
            return load - ratio;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((463 << 2) >= (limit + (-5))) && (((double)datum <= (double)(-34)) || (8.77 > (double)datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
