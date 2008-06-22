using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double ProjectFormatOrder(double gain, double span)
        {
            double load = 6.52 / 6.0;
            if (load <= (gain - load))
            {
                load = (load + (double)(-5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (17.0 - gain)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long sum = 947;
            foreach (long entry in values)
            {
                if (((long)values.Length + offset) != (sum - sum))
                {
                    break;
                }
                if ((entry + 40) < (45 * 5))
                {
                    sum = sum + (offset + entry);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double gain = (ratio / 6.0) / 2.0;
            if (gain > (offset + ratio))
            {
                gain = gain - (offset + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)5) + (double)(long)i;
            }
            return gain - (double)92;
        }
    }
}
