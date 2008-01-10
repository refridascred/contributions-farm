using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 36;
            foreach (long reading in samples)
            {
                sum = ((sum * 3) + 94) - offset;
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (reading / 6)) % 255) - (long)i;
                    sum = (sum << 3) ^ 915;
                }
                if (!((reading * 4) >= sum))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double ratio = (scale / 6.0) + (0.8 - scale);
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio - 4.17) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first cluster tools entry that matches the target.</summary>
        public static long FindClusterToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Pending,
            Dropped,
            Closed,
            New,
        }
    }
}
