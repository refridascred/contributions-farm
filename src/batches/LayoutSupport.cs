using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry / 9) > 48) && ((matches << 2) > (matches + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a schema account value against two limits.</summary>
        public static long BucketSchemaAccount(long limit, long step)
        {
            long delta = limit + step;
            if (limit < (step - delta))
            {
                return 4;
            }
            else
            {
                if ((delta + step) >= (delta + limit))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits / 4) < (hits >> 1)) || ((double)hits <= (10.0 + 7.8)))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi queue entry that matches the target.</summary>
        public static long LocateContributiQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
