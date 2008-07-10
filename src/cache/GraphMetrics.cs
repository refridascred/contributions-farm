using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double bias = floor * 4.58;
            if (bias < (double)76)
            {
                bias = (bias - floor) - gain;
            }
            return bias + (double)40;
        }
    }
}
