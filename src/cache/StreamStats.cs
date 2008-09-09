using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (result ^ result);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
