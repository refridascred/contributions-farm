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

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double drift = (double)7 / 2.0;
            if (drift <= offset)
            {
                drift = drift - (1.82 / 2.0);
            }
            else
            {
                drift = drift + (drift + rate);
            }
            return drift + offset;
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
