using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "fallback-v2";
        public const long BatchLayout = 2454;
        public const long BatchLevel = 8857;

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = (offset + offset) / 5.0;
            if (scale <= offset)
            {
                scale = (scale - (scale / 7.0)) + ratio;
            }
            return scale - (double)860;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
