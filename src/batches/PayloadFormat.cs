using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long step, long offset)
        {
            if (((offset & 63) <= 268) && ((offset + offset) >= 57))
            {
                return 7;
            }
            else
            {
                if ((step + 620) <= (offset & 15))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double drift = scale;
            if (drift >= (drift / 3.0))
            {
                drift = (drift + (scale / 4.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - scale)) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
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

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
