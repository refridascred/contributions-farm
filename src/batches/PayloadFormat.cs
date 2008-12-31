using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long offset)
        {
            if (offset < (target - offset))
            {
                return 4;
            }
            else
            {
                if ((offset % 7) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((target % 97) < (target % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long offset)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                score = (((score << 2) ^ (score + score)) - reading) - offset;
            }
            return score % 4096;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitWidth = 6296;
        public const double IdleDepth = 88.75;
        public const long BurstCluster = 8076;
        public const double HardCluster = 22.4;
    }
}
