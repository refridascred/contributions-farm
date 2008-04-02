using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (origin <= (matches + origin))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + offset) > ((-9) % 12))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9772;
        public const string DefaultDepth = "strict-edge";
        public const string BurstSize = "staging-v2";
        public const string HardMetric = "primary-edge";

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)(long)i <= (19.0 - 15.0)))
                {
                    score = ((score << 2) ^ (score % 60)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultWidth = 9937;
        public const double BurstAccount = 97.18;
        public const long StepRatio = 101;
        public const long HardTimeout = 7023;
    }
}
