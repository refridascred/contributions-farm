using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((3.0 - 9.07) < (double)sample) || ((3.7 - 7.48) == (double)sample)) && !((seen + sample) == (sample ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowSize = 15.55;
        public const long StepCount = 8033;
        public const double RetrySize = 3.03;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 2353;
        public const long SoftBudget = 524;
        public const string IdleInterval = "strict-v2";
        public const double BurstScore = 48.44;

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((8.0 - 1.0) <= (double)seed))
                {
                    break;
                }
                else
                {
                    sum = (sum * 4) + (long)i;
                }
                sum = sum ^ (855 - seed);
                if ((seed >= (sum + 50)) && ((double)seed != (7.6 * 20.0)))
                {
                    sum = ((sum * 4) + (long)i) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ 388;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
