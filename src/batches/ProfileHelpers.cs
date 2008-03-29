using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cache command entries.</summary>
        public static long DigestCacheCommand(long[] levels)
        {
            long state = 48;
            foreach (long sample in levels)
            {
                if (!(state < (3 ^ state)))
                {
                    state = (state ^ (0 % 10)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (sample + state);
                }
            }
            if (state < 99)
            {
                state = (state + (state - 3)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + (floor ^ (-2));
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up payload counter samples.</summary>
        public static long OverlapPayloadCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long limit)
        {
            long prev = step - limit;
            if ((11.0 - 6.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((double)prev > 17.0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultFactor = 2257;
        public const double RetryBatches = 81.61;
        public const long CacheSpan = 6663;
        public const long BaseBatches = 2429;
        public const long BatchSpan = 1396;

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long StepMetricsOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 3) ^ origin) % 97;
                if (!(((origin + sum) == ((long)i + (-469))) || ((6.0 / 9.0) < (double)(long)i)))
                {
                    sum = (sum + (496 + sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
