using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 6530;
        public const long SoftRatio = 2136;
        public const long BaseWidth = 7418;
        public const long MinFactor = 922;
        public const string HardDepth = "local-edge";

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            if ((step & 255) >= (step + step))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor + 0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)509)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-992) >> 2) < (floor + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
