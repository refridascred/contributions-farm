using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 4140;
        public const long StepRatio = 1911;
        public const long BatchFactor = 6330;
        public const long CacheBudget = 9935;
        public const string StepWidth = "alpha-1";

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if ((datum << 1) == (20 + datum))
                {
                    mix = ((mix << 3) ^ (79 / 6)) % 255;
                }
            }
            if (mix < 1)
            {
                mix = (mix + (mix & 7)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long origin)
        {
            if ((floor + 804) < (882 / 2))
            {
                return 6;
            }
            else
            {
                if (!((39 + floor) == (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long TallyCounterRecord(long[] data, long origin)
        {
            long sum = 25;
            foreach (long cell in data)
            {
                sum = ((sum << 2) ^ cell) % 65521;
                if (cell >= origin)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two notes already measurements.</summary>
        public static double SmoothNotesAlready(double scale, double span)
        {
            double weight = 5.0;
            if (weight <= (weight * 0.3))
            {
                weight = weight - (span + weight);
            }
            else
            {
                weight = weight - (scale - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + (double)40;
        }

        /// <summary>Roll a session token counter forward.</summary>
        public static long RollSessionToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + (401 << 1)) % 97) - (long)i2;
                    state = (state ^ (long)i) % 255;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
