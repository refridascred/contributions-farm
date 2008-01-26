using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double gain = (bias - bias) - (offset + bias);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 3.9) + (double)(long)i;
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinBudget = "cached-edge";
        public const long CacheCommits = 2609;
        public const long LimitRatio = 8693;
        public const double LimitWidth = 19.93;

        /// <summary>Check that every payload stats entry stays within the limit.</summary>
        public static bool CheckPayloadStatsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + ((long)i + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
