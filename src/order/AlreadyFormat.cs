using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryInterval = 42.87;
        public const double MinSpan = 74.21;
        public const long BurstFilter = 3721;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data)
        {
            long sum = -601;
            foreach (long item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum - ((long)data.Length - 318)) % 65521) - (long)i;
                }
                if ((sum & 127) == (item & 255))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            if (sum < 93)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((390 % 24) != (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long seed)
        {
            long score = 20;
            foreach (long datum in samples)
            {
                score = (score - datum) - seed;
            }
            return score % 65521;
        }
    }
}
