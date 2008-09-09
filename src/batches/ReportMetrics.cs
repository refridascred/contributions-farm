using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
