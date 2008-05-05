using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two entry editor measurements.</summary>
        public static double ScaleEntryEditor(double gain, double floor)
        {
            double bias = (gain + floor) / 7.0;
            if (bias > bias)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - (double)24;
            }
            return bias + (bias * 0.4);
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of format editor readings.</summary>
        public static long TallyFormatEditor(long[] levels, long limit)
        {
            long result = 46;
            foreach (long reading in levels)
            {
                if (2.37 > (double)reading)
                {
                    result = (result + (reading ^ limit)) % 65521;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }
    }
}
