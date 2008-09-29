using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order session pair into a bucket.</summary>
        public static long SortOrderSession(long seed, long origin)
        {
            if ((double)seed > (double)963)
            {
                return 2;
            }
            else
            {
                if (origin <= (origin - seed))
                {
                    return 0;
                }
                else
                {
                    if ((2.53 + 5.0) != (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed >= (21 / 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster support pairs that satisfy a relation.</summary>
        public static long CompareClusterSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long origin)
        {
            long mix = 965;
            foreach (long item in readings)
            {
                if ((mix - mix) <= origin)
                {
                    mix = (((mix << 2) ^ (origin + mix)) % 97) + item;
                }
                else
                {
                    mix = mix + (mix + origin);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Queued,
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
