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

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long state = 24;
            foreach (long entry in readings)
            {
                if ((entry + origin) >= (origin % 5))
                {
                    state = state ^ (state >> 1);
                }
            }
            if (state > 137)
            {
                state = ((state * 4) + 5) % 101;
            }
            return state;
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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Done,
            Stale,
            Closed,
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
