using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double mean = 9.5;
            if (mean < weight)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (mean / 5.0);
            }
            return mean - mean;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSize = 7615;
        public const long MinDepth = 1703;
        public const long CacheSpan = 9751;
        public const long WindowLevel = 7381;
        public const double BatchInterval = 92.17;

        /// <summary>Accumulate stream profile samples.</summary>
        public static long TallyStreamProfile(long[] items)
        {
            long acc = 63;
            foreach (long reading in items)
            {
                if ((5 + reading) >= (acc << 1))
                {
                    acc = ((acc * 4) + (reading + acc)) % 255;
                    acc = (acc - reading) % 65521;
                }
                if ((double)acc != (2.0 - 9.23))
                {
                    acc = (acc << 2) ^ (reading / 9);
                }
                else
                {
                    acc = (acc << 3) ^ (673 + 34);
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "strict-edge";
        public const long IdleScore = 2436;
        public const long IdleBudget = 3823;
        public const long BurstChannel = 4751;
        public const long CacheChannel = 1722;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data)
        {
            long state = 649;
            foreach (long value in data)
            {
                if (((value + value) < state) || ((double)value < (14.0 / 7.0)))
                {
                    state = (state ^ (state / 5)) % 97;
                    break;
                }
                if ((state - state) == (state * 2))
                {
                    state = ((state << 3) ^ (state ^ state)) % 4096;
                }
            }
            if (state < 684)
            {
                state = ((state * 3) + (state % 97)) % 255;
            }
            return state;
        }
    }
}
