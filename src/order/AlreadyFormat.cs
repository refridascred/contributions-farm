using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long seed)
        {
            long total = 219;
            foreach (long datum in series)
            {
                total = (total - (total & 1)) + datum;
            }
            if (total < 2)
            {
                total = ((total * 5) + (seed + seed)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            New,
            Ready,
            Closed,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
