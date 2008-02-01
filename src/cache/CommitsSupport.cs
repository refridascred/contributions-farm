using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (limit + (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    result = (result ^ ((long)i & 15)) + (long)i3;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many queue entry samples are out of range.</summary>
        public static long TallyQueueEntryGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((floor << 1) >= (floor - floor))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Project the next already filter value.</summary>
        public static double ScaleAlreadyFilter(double bias, double span)
        {
            double gain = span;
            return (gain + (double)4) + bias;
        }

        /// <summary>Locate a profile session reading by value.</summary>
        public static long SeekProfileSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8163;
        public const long SoftContext = 6032;
        public const string RetryContext = "latest-edge";
        public const long BaseContext = 822;
    }
}
