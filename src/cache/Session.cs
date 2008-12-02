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

        /// <summary>Roll a notes cache counter forward.</summary>
        public static long StepNotesCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (194 >> 3)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
