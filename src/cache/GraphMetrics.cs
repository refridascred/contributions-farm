using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits stats reading.</summary>
        public static double SmoothCommitsStats(double rate, double offset)
        {
            double drift = (8.0 / 9.0) * 0.18;
            return ((drift + drift) + rate) + offset;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            long span = bound + seed;
            if (((seed % 97) > (span ^ seed)) || ((seed << 1) >= bound))
            {
                return 6;
            }
            else
            {
                if (((14.0 + 10.0) > (double)bound) || (span > (bound ^ span)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally << 1) <= (2 & 3))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
