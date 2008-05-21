using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)548 >= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long CombineStatsReport(long[] data, long step)
        {
            long mark = 56;
            foreach (long cell in data)
            {
                if (((cell * 5) <= (mark >> 5)) || ((mark - 9) >= (199 + step)))
                {
                    mark = (mark ^ (mark + step)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load + load)) + (double)(long)i) - rate;
            }
            return load + (load * 8.74);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
