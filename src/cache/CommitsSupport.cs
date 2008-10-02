using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally & 3) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache already reading by value.</summary>
        public static long LookupCacheAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((diff + seed) < seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 << 1) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 + seed) > diff) && ((seed % 64) == (seed2 ^ diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
