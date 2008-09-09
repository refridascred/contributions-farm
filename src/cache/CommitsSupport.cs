using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 1461;
        public const long DefaultDepth = 3658;
        public const double SoftBatches = 11.61;
        public const long BurstBatches = 741;
        public const long SoftRatio = 1109;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Queued,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double gain2 = (offset / 7.0) * 5.4;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (gain2 - 8.3)) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)bound < (5.7 * 9.8))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long step)
        {
            long slot = target - step;
            if ((double)target >= (double)slot)
            {
                return 8;
            }
            else
            {
                if ((target + step) > (step << 2))
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ step) == (target - 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
