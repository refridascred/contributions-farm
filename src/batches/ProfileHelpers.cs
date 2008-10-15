using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of counter metric readings.</summary>
        public static long CombineCounterMetric(long[] data, long origin)
        {
            long acc = -76;
            foreach (long item in data)
            {
                if ((18.0 / 5.0) != (double)acc)
                {
                    break;
                }
                if (((origin * 2) > (origin * 3)) && ((3.2 / 3.0) < (double)origin))
                {
                    acc = (((acc * 5) + ((long)data.Length + origin)) % 65521) - item;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstScore = 64.93;
        public const long StepScore = 5115;
        public const long RetryRatio = 1518;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
            New,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((double)score != (4.4 * 1.3)) || (origin >= ((long)i * 2)))
                {
                    score = (score + origin) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (score + 24)) % 255) ^ (long)i2;
                    score = ((score << 3) ^ (85 - score)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
