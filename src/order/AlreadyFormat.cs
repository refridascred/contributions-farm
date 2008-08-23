using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 75.49;
        public const double LimitSupport = 25.44;
        public const long SoftSpan = 9578;
        public const string BurstRatio = "local-edge";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((8.1 - 12.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + step) < 85) || ((bound + step) > step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= (reading & 7)))
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardTimeout = "strict-v2";
        public const long SoftEntry = 9978;
        public const long LimitSize = 2920;
        public const long MaxEntry = 5287;
        public const long BatchInterval = 9346;
    }
}
