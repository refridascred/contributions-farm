using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks stats readings.</summary>
        public static long TallyChecksStats(long[] items)
        {
            long score = 33;
            foreach (long entry in items)
            {
                if (score >= (entry - score))
                {
                    score = score - (entry - score);
                }
            }
            return score;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double bias)
        {
            double gain = bias - (rate + rate);
            if (gain > (double)560)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (rate + rate);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
