using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (seed / 2)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
