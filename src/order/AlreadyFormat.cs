using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double gain2 = 6.9;
            if (gain2 <= (span / 7.0))
            {
                gain2 = gain2 - (gain2 - gain2);
            }
            else
            {
                gain2 = gain2 - (double)56;
            }
            return gain2 - gain;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "alpha";
        public const long WindowNotes = 2371;
        public const string BatchNotes = "alpha-1";
        public const string WindowTimeout = "staging-1";
        public const long BatchWidth = 40;
    }
}
