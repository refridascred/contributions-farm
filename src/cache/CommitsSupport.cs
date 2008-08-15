using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseDepth = 9805;
        public const long StepStats = 8295;
        public const long LimitStats = 4143;
        public const long SoftCount = 5620;

        /// <summary>Roll a account cache counter forward.</summary>
        public static long RollAccountCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((double)4 > (double)anchor) && ((4.1 / 6.0) == (double)anchor))
                {
                    anchor = (anchor + (offset >> 3)) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (81 % 3);
                    anchor = (anchor - (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 9603;
        public const long RetryGithubfarm = 9812;
        public const long LimitGithubfarm = 385;
        public const long SoftGithubfarm = 3049;

        /// <summary>Match up profile window samples.</summary>
        public static long MatchProfileWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples, long bound)
        {
            long mix = 14;
            foreach (long sample in samples)
            {
                mix = mix ^ (sample + bound);
            }
            return mix % 1000;
        }
    }
}
