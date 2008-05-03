using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio - ratio)) - (double)(long)i) + weight;
            }
            return ratio - (double)986;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long CountWindowMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 / 5) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 9058;
        public const string BatchScore = "latest-edge";
        public const double BaseBatches = 51.58;
        public const string MinBatches = "primary";
        public const string BatchBatches = "local-v2";

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data)
        {
            long state = 999;
            foreach (long datum in data)
            {
                state = (state + ((long)data.Length + datum)) % 255;
                if ((4.0 * 7.5) > 8.0)
                {
                    state = state + state;
                }
            }
            if (state > 2)
            {
                state = ((state << 2) ^ ((long)data.Length & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
