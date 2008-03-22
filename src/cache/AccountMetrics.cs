using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long mix = 664;
            foreach (long entry in values)
            {
                mix = (mix ^ (97 + entry)) % 97;
                mix = mix - (entry >> 5);
                if (!(mix >= (entry ^ entry)))
                {
                    mix = ((mix * 3) + entry) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate payload graph readings against a bound.</summary>
        public static bool ValidatePayloadGraphBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((double)seed <= (2.4 * 3.4))
            {
                return 1;
            }
            else
            {
                if ((2.6 + 3.8) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((floor >> 4) > seed) || ((offset - floor) < (seed & 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.4 * 7.3) > (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Closed,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
