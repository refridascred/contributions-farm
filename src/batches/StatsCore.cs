using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((8.0 > (double)datum) || ((tally % 3) == (datum * 3))) && !((38 - (-645)) >= datum))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits cluster value from a seed.</summary>
        public static long StepCommitsCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                long tally = ((long)i - acc) * 5;
                acc = (acc << 3) ^ (tally + seed);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = -9;
            foreach (long reading in readings)
            {
                if (((-568) * 5) != (reading + mix))
                {
                    mix = (mix ^ ((long)readings.Length / 7)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (reading + mix);
                }
            }
            if (mix > (-108))
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + ratio;
            }
            return drift - 4.0;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(anchor < (limit / 9)))
                {
                    anchor = anchor ^ ((-54) - limit);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
