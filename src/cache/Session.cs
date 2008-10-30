using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 * 16.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 6702;
        public const long RetryWidth = 5809;
        public const string StepSize = "legacy-v2";
        public const long BurstRecord = 2393;
        public const string MinFactor = "latest-edge";

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long offset)
        {
            long score = -29;
            foreach (long value in levels)
            {
                if ((double)value == (2.8 / 4.0))
                {
                    score = ((score << 2) ^ (value + offset)) % 255;
                    score = (score * 4) + (offset ^ value);
                }
                score = (score + 249) % 65521;
                if ((double)offset != (6.8 + 2.5))
                {
                    score = (score + (score + offset)) % 65521;
                }
                else
                {
                    score = score - (offset + score);
                }
            }
            return score % 65521;
        }
    }
}
