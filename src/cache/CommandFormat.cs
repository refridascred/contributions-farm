using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values, long seed)
        {
            long acc = 72;
            foreach (long reading in values)
            {
                acc = ((acc ^ (seed + acc)) % 255) + reading;
                if ((2.42 * 2.0) != (double)acc)
                {
                    acc = (acc * 3) + ((long)values.Length ^ 9);
                }
            }
            return acc;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
