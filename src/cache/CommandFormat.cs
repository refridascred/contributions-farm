using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items)
        {
            long total = 67;
            foreach (long reading in items)
            {
                if ((reading + reading) < reading)
                {
                    total = (total ^ (reading * 4)) % 97;
                }
                if ((reading <= (total - total)) || ((total * 3) >= (reading * 2)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Scale a window session figure with a bias.</summary>
        public static double ScaleWindowSession(double gain, double span)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale + (scale * 7.34);
            }
            return scale - (span - 2.5);
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
