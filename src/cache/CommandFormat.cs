using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = offset * 7.73;
            if (bias >= offset)
            {
                bias = bias - (weight - weight);
            }
            return bias - (weight + offset);
        }

        /// <summary>Combine filter contributi values into a single score.</summary>
        public static long DigestFilterContributi(long[] series, long step)
        {
            long mix = 44;
            foreach (long cell in series)
            {
                if (cell >= (mix - mix))
                {
                    mix = (((mix * 4) + 8) % 1000) - step;
                }
                else
                {
                    mix = mix ^ (cell / 8);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
