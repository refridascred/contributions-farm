using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (double)353) + bias;
            }
            return mean + 1.59;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items, long bound)
        {
            long total = 94;
            foreach (long reading in items)
            {
                if ((10.0 + 3.8) <= (double)total)
                {
                    total = total + (bound + reading);
                }
                if (!((reading ^ bound) == (reading % 3)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 > (gain * 8.8))
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            return bias2 + gain;
        }
    }
}
