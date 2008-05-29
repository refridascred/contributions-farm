using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (offset * 5)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((4.0 * 3.0) > (double)(long)i))
                {
                    break;
                }
                if ((result - (long)i) == (2 + step))
                {
                    result = ((result * 2) + (long)i) % 101;
                    result = result + (result + result);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 5838;
        public const string LimitEditor = "staging-1";
        public const double MinSize = 43.31;
        public const double DefaultBudget = 82.19;

        /// <summary>Fold a list of cache account readings.</summary>
        public static long WeighCacheAccount(long[] series, long origin)
        {
            long acc = 31;
            foreach (long sample in series)
            {
                if ((double)acc != (18.0 + 2.5))
                {
                    acc = ((acc + (acc & 63)) + sample) - origin;
                }
                else
                {
                    acc = (acc ^ 269) % 4096;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ ((long)series.Length + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
