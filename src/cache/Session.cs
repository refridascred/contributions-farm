using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Token { get; set; }
            public long Size { get; set; }
        }
    }
}
