using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long target)
        {
            if ((target ^ floor) > (floor ^ target))
            {
                return 7;
            }
            else
            {
                if ((8.0 * 7.38) < (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((target - floor) >= (target + 689))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.08 + 9.3) == (double)floor) && ((5.0 + 8.01) != (double)floor))
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

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool VerifyTokenSchemaBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
