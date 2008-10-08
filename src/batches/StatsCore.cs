using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5819;
        public const long BurstFilter = 8628;
        public const long CacheFilter = 7736;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((7.1 - 2.3) < (double)count)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long floor)
        {
            long delta = origin + floor;
            if (floor < (origin % 10))
            {
                return 6;
            }
            else
            {
                if (((double)origin != (6.0 / 7.0)) && ((floor + delta) != (floor * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((506 / 9) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor >= (11.0 / 8.0)) && ((floor + (-49)) <= 881))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
