using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double ScaleSupportFarm(double bias, double bias2)
        {
            double load = bias2;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + 6.9) + (double)(long)i) + bias;
            }
            return load + 9.2;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long seed)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ seed;
                if (((anchor + datum) > anchor) || (anchor <= seed))
                {
                    anchor = anchor - (anchor << 3);
                }
            }
            if (anchor < (-49))
            {
                anchor = ((anchor * 4) + (seed << 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
