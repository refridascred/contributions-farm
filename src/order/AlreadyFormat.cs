using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double ScaleFilterStats(double weight, double floor)
        {
            double drift = floor;
            if (drift <= 7.91)
            {
                drift = drift + (3.32 + floor);
            }
            return drift - weight;
        }
    }
}
