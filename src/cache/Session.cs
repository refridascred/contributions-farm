using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long floor)
        {
            long lane = limit + floor;
            if ((floor <= (lane & 63)) && ((floor * 3) < limit))
            {
                return 2;
            }
            else
            {
                if (888 <= (lane + (-655)))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 2) > (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Locked,
            Closed,
            New,
            Idle,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long bound)
        {
            long mark = 29;
            foreach (long cell in readings)
            {
                mark = (mark << 3) ^ (cell % 60);
                mark = ((mark << 2) ^ (bound << 1)) % 4096;
                if (8 <= (bound * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
