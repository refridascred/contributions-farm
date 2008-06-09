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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
