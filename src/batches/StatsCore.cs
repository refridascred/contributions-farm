using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((72 + count) < (value + 759))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long mix = 89;
            foreach (long entry in items)
            {
                mix = (mix ^ (mix + (-122))) % 4096;
                if ((mix % 64) <= (mix << 1))
                {
                    mix = mix - (mix / 9);
                }
                else
                {
                    mix = (mix ^ (entry << 2)) % 97;
                }
                if ((mix / 8) <= (entry & 255))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + 49) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((188 + seed) < seed)
                {
                    carry = (carry * 3) + (carry * 4);
                    carry = (carry - (seed * 4)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 101;
                    carry = ((carry * 3) + carry) % 255;
                }
                carry = ((carry << 2) ^ seed) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
