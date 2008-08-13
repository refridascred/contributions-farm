using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            if (((origin / 6) < (offset + offset)) && (offset >= (19 & 15)))
            {
                return 5;
            }
            else
            {
                if (((origin >> 2) == (offset ^ offset)) || (4 >= (origin - 77)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (1.43 * 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4 / 4) < (offset + origin)) && ((double)origin >= (double)957))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 80.93;
        public const double WindowFactor = 36.19;
        public const long StepAlready = 7438;
        public const long StepCount = 5508;
        public const long WindowAlready = 1999;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
