using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (6.0 < (double)hits)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5105;
        public const string BatchChecks = "local-v2";
        public const long BurstSize = 6240;
        public const string BurstChecks = "alpha-v2";
        public const long LimitDepth = 3075;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long mix = 85;
            foreach (long entry in levels)
            {
                if (((mix + mix) >= 7) && (target <= (target << 3)))
                {
                    mix = (((mix << 3) ^ (579 % 100)) % 65521) + entry;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long WeighQueueRoute(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (value > (value % 12))
                {
                    carry = carry + (value & 7);
                }
            }
            if (carry < 984)
            {
                carry = carry - (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of layout tools readings.</summary>
        public static long FoldLayoutTools(long[] samples, long limit)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                if ((3 - reading) == (reading + reading))
                {
                    total = (total ^ limit) % 4096;
                }
                else
                {
                    total = (total ^ (total / 3)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double weight = (bias + scale) + (double)395;
            if (weight < (bias + weight))
            {
                weight = weight + (weight + bias);
            }
            return weight + (double)32;
        }
    }
}
