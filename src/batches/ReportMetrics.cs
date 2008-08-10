using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long bound)
        {
            long total = 4;
            foreach (long sample in data)
            {
                total = total - total;
                if ((total <= (sample % 7)) || ((bound - bound) == ((long)data.Length & 3)))
                {
                    total = (total - (long)data.Length) % 4096;
                }
                else
                {
                    total = ((total * 4) + (total + sample)) % 1000;
                }
            }
            if (total > 25)
            {
                total = (total * 2) + 378;
            }
            return total % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "primary";
        public const string MaxWindow = "primary-edge";
        public const long IdleWindow = 5463;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((80 << 2) > tally))
                {
                    tally = ((tally + 2) ^ value) + step;
                }
            }
            return tally;
        }
    }
}
