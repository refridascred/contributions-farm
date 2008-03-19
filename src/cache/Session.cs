using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor + floor) <= 5)
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (8.2 - 1.56))
                {
                    return 7;
                }
                else
                {
                    if ((792 + delta) >= (2 - 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long floor)
        {
            long acc = -29;
            foreach (long datum in readings)
            {
                if ((1.37 - 7.7) != (double)acc)
                {
                    acc = acc - (acc << 3);
                }
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ acc) % 65521) - (long)i;
                }
                if ((datum + floor) <= (26 + datum))
                {
                    acc = acc + (long)readings.Length;
                }
            }
            if (acc < 209)
            {
                acc = acc ^ floor;
            }
            return acc;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
