using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)offset != (14.0 + 5.0))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + 7) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long seed)
        {
            long edge = target ^ seed;
            if ((target * 4) < (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if ((96 ^ target) > edge)
                {
                    return 6;
                }
                else
                {
                    if ((target > (target ^ edge)) || ((1.11 - 18.0) > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up already buffer samples.</summary>
        public static long MatchAlreadyBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((0.8 - 9.99) > (double)hits)
                {
                    hits = ((hits + 2) ^ reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
