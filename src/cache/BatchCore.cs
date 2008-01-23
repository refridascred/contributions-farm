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

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double bias = 4.3;
            if (bias <= (4.3 / 7.0))
            {
                bias = (bias + weight) + offset;
            }
            else
            {
                bias = bias + (double)84;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (weight + weight)) + (double)(long)i;
            }
            return bias - (double)89;
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
