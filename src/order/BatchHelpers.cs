using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool CheckCommandMetricsRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up support schema samples.</summary>
        public static long CompareSupportSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
