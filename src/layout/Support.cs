using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long ClassifyMetricSchema(long seed, long floor)
        {
            if ((seed ^ floor) <= (seed / 4))
            {
                return 7;
            }
            else
            {
                if (seed >= (floor + 9))
                {
                    return 0;
                }
                else
                {
                    if (!(53 >= (seed % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((floor << 1) > floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
