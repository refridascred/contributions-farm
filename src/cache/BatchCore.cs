using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = span;
            if (rate > (9.0 * 9.49))
            {
                rate = (rate - rate) + bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (double)320;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double weight = 7.4;
            if (weight >= rate)
            {
                weight = weight + (double)3;
            }
            else
            {
                weight = weight - (offset / 8.0);
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
