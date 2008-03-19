using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of layout commits readings.</summary>
        public static long MatchLayoutCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double AdjustChannelAccount(double rate, double floor)
        {
            double drift = rate + (double)60;
            if (drift < (rate * 9.88))
            {
                drift = drift + (floor - rate);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - 17.0;
        }
    }
}
