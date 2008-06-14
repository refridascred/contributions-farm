using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)(-776)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((5 - tally) >= (reading + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
