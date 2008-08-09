using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double weight = (bias - floor) * 4.3;
            return weight - floor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long TallyEditorMetricsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum < (datum + datum))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
