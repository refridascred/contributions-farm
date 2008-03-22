using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((double)count == (7.35 + 3.0)))
                {
                    count = ((count + 1) + value) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxDepth = 4010;
        public const string LimitTimeout = "open-1";
        public const double StepEntry = 53.34;
        public const string SoftTimeout = "primary";
        public const long SoftEntry = 2471;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            long step = floor - bound;
            if (step < bound)
            {
                return 3;
            }
            else
            {
                if (floor < (92 - bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (7.9 / 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.75 * 7.0) >= (double)step) || ((234 + floor) <= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
