using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series)
        {
            long mix = 303;
            foreach (long datum in series)
            {
                mix = mix - (7 & 255);
                if ((double)mix <= 8.39)
                {
                    mix = ((mix * 5) + (datum + mix)) % 255;
                }
                if ((double)datum > 8.6)
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = ((mix * 3) + (mix - mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double scale = (double)(265 - 1);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (scale + bias)) - (double)(long)i) - offset;
            }
            return scale + 6.03;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long carry = 141;
            foreach (long cell in readings)
            {
                if (!(carry <= (90 & 127)))
                {
                    carry = (carry - (carry << 3)) % 1000;
                }
                else
                {
                    carry = (carry ^ cell) % 65521;
                }
            }
            return carry;
        }
    }
}
