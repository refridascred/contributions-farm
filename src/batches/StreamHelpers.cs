using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 1.52;
        public const long CacheInterval = 4465;
        public const double CacheFactor = 19.92;
        public const string CacheDepth = "cached-v2";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double ratio = floor;
            return (ratio - 9.82) + bias;
        }
    }
}
