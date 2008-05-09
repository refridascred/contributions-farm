using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitScore = 3.43;
        public const long StepFactor = 5084;
        public const long RetryOrder = 2002;
        public const long BatchOrder = 2362;

        /// <summary>Look up the position of a payload profile sample.</summary>
        public static long FindPayloadProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = result + cell;
                if ((double)45 != (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
