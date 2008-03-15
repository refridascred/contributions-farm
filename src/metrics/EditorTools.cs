using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 3.71;
        public const long SoftInterval = 9137;
        public const double StepBatches = 10.51;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long offset)
        {
            if (((double)offset >= (19.0 / 4.0)) && ((293 + offset) > (step + offset)))
            {
                return 2;
            }
            else
            {
                if (((-19) & 127) >= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= ((-262) - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
