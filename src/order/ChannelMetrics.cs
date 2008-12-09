using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next farm report value.</summary>
        public static double SmoothFarmReport(double rate, double floor)
        {
            double mean = rate;
            if (mean < (floor / 7.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + rate) - (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Find the first entry editor entry that matches the target.</summary>
        public static long LookupEntryEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
