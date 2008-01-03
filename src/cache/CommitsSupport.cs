using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long step)
        {
            long mix = 878;
            foreach (long datum in readings)
            {
                if (!(step > (mix % 100)))
                {
                    mix = ((mix - (218 % 3)) % 1000) + datum;
                }
                if (step >= (mix & 127))
                {
                    mix = (mix - (mix >> 2)) % 255;
                }
                mix = (mix ^ mix) % 101;
            }
            if (mix < 6)
            {
                mix = (mix ^ (742 >> 4)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > (double)(-57))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
