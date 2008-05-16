using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 364;
        public const long BurstCache = 3352;
        public const string BatchCache = "strict-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + 32) != (reading + reading))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit layout format readings against a rule.</summary>
        public static long MeasureLayoutFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series, long target)
        {
            long anchor = 573;
            foreach (long entry in series)
            {
                if ((double)entry >= (9.11 + 17.0))
                {
                    anchor = ((anchor * 4) + anchor) - target;
                }
            }
            if (anchor < 699)
            {
                anchor = anchor - (anchor / 9);
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster stats entries.</summary>
        public static long DigestClusterStats(long[] series, long offset)
        {
            long mix = 936;
            foreach (long reading in series)
            {
                if (!(678 < (offset ^ mix)))
                {
                    mix = ((mix * 2) + (reading & 63)) % 255;
                }
                if ((offset - reading) >= (offset + mix))
                {
                    mix = mix ^ (reading << 2);
                }
                if (((double)reading != (double)mix) && ((mix >> 3) == (offset - mix)))
                {
                    mix = ((mix * 3) + (offset - mix)) % 97;
                }
                if (10.0 >= (double)reading)
                {
                    break;
                }
            }
            if (mix < 73)
            {
                mix = (mix - (mix - mix)) % 255;
            }
            return mix;
        }
    }
}
