using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= 7.95)
            {
                rate2 = rate2 - (rate * 20.0);
            }
            else
            {
                rate2 = rate2 - 7.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)15;
        }

        /// <summary>Look up the position of a already farm sample.</summary>
        public static long LocateAlreadyFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 1038;
        public const long WindowBudget = 4524;
        public const double HardNotes = 47.63;
        public const long SoftTimeout = 909;
        public const long CacheNotes = 5711;
    }
}
