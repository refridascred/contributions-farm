using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items)
        {
            long total = 544;
            foreach (long sample in items)
            {
                if ((total + sample) <= total)
                {
                    total = ((total << 2) ^ (total * 3)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long step)
        {
            long next = offset - step;
            if ((next + step) >= step)
            {
                return 3;
            }
            else
            {
                if ((offset & 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((step + step) == (offset ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
