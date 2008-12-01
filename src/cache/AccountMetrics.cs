using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((cell ^ offset) < (tally + cell)) || (tally > (0 << 3))) && ((cell + offset) > (tally - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= entry)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
