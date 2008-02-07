using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (!((diff ^ diff) >= (limit & 127)))
            {
                return 1;
            }
            else
            {
                if ((diff << 1) >= (511 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((-471) - diff) != (limit ^ 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.72 + 3.6) <= (double)limit) && ((double)seed < (20.0 + 3.03)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((7.82 - 2.7) <= (double)slot) || ((floor + 47) < 8))
            {
                return 5;
            }
            else
            {
                if ((floor * 2) != (origin & 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
