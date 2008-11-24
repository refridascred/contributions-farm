using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long bound2)
        {
            if ((bound & 7) <= (bound + bound2))
            {
                return 1;
            }
            else
            {
                if ((5.9 - 8.2) == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((8.32 * 1.3) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate farm metric samples.</summary>
        public static long DigestFarmMetric(long[] items)
        {
            long carry = -86;
            foreach (long value in items)
            {
                if ((double)carry >= (2.9 / 3.0))
                {
                    carry = (carry ^ (carry << 1)) % 255;
                }
                if ((carry + value) < 724)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
