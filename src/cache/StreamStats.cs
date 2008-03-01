using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a commits record reading by value.</summary>
        public static long SeekCommitsRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache context figure with a bias.</summary>
        public static double ProjectCacheContext(double ratio, double floor)
        {
            double drift = 2.3 - ratio;
            if (drift <= ratio)
            {
                drift = (drift - drift) - floor;
            }
            return drift + (drift / 4.0);
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long ClassifyContributiStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((limit + 90) > (limit << 2))
            {
                return 4;
            }
            else
            {
                if (!((limit & 127) >= (35 / 5)))
                {
                    return 3;
                }
                else
                {
                    if (((slot % 12) > limit) && (limit < (limit & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
