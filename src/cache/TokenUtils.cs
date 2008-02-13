using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((seen + seen) >= (seen << 1)) && ((20.0 + 9.0) == (double)(long)items.Length)) || ((double)seen > 8.2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double load = gain;
            if (load <= offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (9.0 - gain);
            }
            return load + (double)963;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
