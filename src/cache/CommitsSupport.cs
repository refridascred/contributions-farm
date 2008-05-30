using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((649 >= entry) || ((entry + (-26)) > count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((300 << 2) == (cell & 127)) || (cell <= hits)) || ((double)hits >= 1.16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2903;
        public const long BatchWidth = 7132;
        public const long WindowCache = 9199;
        public const string MaxCache = "standard-1";
        public const long MinFactor = 1914;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double load = (double)113;
            if (load > (bias / 6.0))
            {
                load = load - offset;
            }
            return load + bias;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((4.0 + 9.0) > (double)bound) || ((reading + matches) >= bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
