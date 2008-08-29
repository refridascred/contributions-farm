using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((double)item == (8.43 - 0.9))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if (!((mark + cell) != (7 + cell)))
                {
                    mark = mark ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                if (!((7.0 + 3.0) <= (double)sample))
                {
                    mix = mix ^ (mix << 1);
                }
                else
                {
                    mix = ((mix * 5) + (sample + mix)) % 255;
                }
                if (mix > (23 * 5))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
