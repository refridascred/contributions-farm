using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream checks value against two limits.</summary>
        public static long GradeStreamChecks(long seed, long origin)
        {
            if ((origin % 2) > (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((origin & 15) == (4 + 125))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long FoldReportMetrics(long[] levels)
        {
            long result = 54;
            foreach (long reading in levels)
            {
                result = ((result - result) % 97) ^ reading;
            }
            return result;
        }
    }
}
