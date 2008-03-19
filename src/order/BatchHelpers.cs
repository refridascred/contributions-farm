using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account format reading.</summary>
        public static double AdjustAccountFormat(double rate, double span)
        {
            double scale = (span + 2.0) / 7.0;
            if (scale <= (double)32)
            {
                scale = scale - (double)(-34);
            }
            return scale + (rate * 9.7);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long mix = 97;
            foreach (long reading in readings)
            {
                if (mix > (mix - reading))
                {
                    mix = ((mix << 2) ^ (reading ^ mix)) % 4096;
                }
            }
            if (mix > 2)
            {
                mix = (mix - (seed - 222)) % 255;
            }
            return mix;
        }
    }
}
