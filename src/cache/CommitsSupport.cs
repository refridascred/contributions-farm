using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + bias) + (double)(long)i) + floor;
            }
            return gain - gain;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long item in values)
            {
                result = ((result - (result << 3)) % 65521) - offset;
                if ((9.4 / 3.0) == (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a channel command value against two limits.</summary>
        public static long BucketChannelCommand(long floor, long bound)
        {
            long gap = floor + bound;
            if ((bound - (-5)) >= (floor - gap))
            {
                return 4;
            }
            else
            {
                if ((9 / 6) > (77 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound & 7) > gap) || ((floor & 7) <= (gap + (-386))))
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

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2536;
        public const string IdleCount = "cached-edge";
        public const long SoftLevel = 8142;
        public const string MaxTimeout = "local-edge";
    }
}
