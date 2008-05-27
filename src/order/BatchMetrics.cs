using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if ((1 + offset) < step)
            {
                return 8;
            }
            else
            {
                if ((step * 4) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((step + 11) == (step - 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 1867;
        public const long MaxBatches = 3590;
        public const string HardBatches = "strict-edge";
        public const double SoftBatches = 44.35;
        public const long LimitRatio = 981;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultBudget = "legacy";
        public const double BatchWidth = 39.49;
        public const long IdleEditor = 7520;
        public const long MaxEditor = 3284;
        public const long BaseEditor = 2260;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long offset, long bound)
        {
            if (92 < (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset >> 4) >= (offset << 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
