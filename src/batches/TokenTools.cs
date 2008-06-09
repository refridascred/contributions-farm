using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double weight = offset;
            if (weight < (double)(-978))
            {
                weight = weight + (7.2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (rate - rate)) - (double)(long)i;
            }
            return weight + (rate * 9.1);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftFactor = 7550;
        public const long IdleWidth = 9472;
        public const long StepContributi = 1316;
    }
}
