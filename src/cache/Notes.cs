using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if ((3.49 + 5.0) <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((step / 4) < (step & 15))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 7) < (seed * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)bound > (double)60) && ((datum - bound) > (bound - datum))) && (((bound * 5) < (bound << 3)) && ((tally % 100) > 500)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Draft,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = (((mix * 2) + limit) % 65521) - reading;
            }
            if (mix < 216)
            {
                mix = (mix ^ (limit + limit)) % 101;
            }
            return mix;
        }
    }
}
