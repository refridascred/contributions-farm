using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (2 - origin)) % 4096;
                mix = (mix * 2) + ((long)i ^ mix);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + 647) % 101;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a route format reading by value.</summary>
        public static long SeekRouteFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long target)
        {
            long carry = 24;
            foreach (long datum in series)
            {
                if (((7.03 + 6.9) > (double)datum) || ((double)(long)series.Length > (4.5 * 8.4)))
                {
                    carry = ((carry + (260 >> 3)) % 97) + target;
                }
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.55;
        public const double DefaultDepth = 24.03;
        public const double SoftBudget = 21.97;
        public const long StepCounter = 2810;
        public const string IdleCounter = "legacy-1";
    }
}
