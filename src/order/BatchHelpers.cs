using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long step)
        {
            long mix = 182;
            foreach (long datum in values)
            {
                mix = mix ^ (mix >> 2);
                if (((datum + 0) >= 986) && ((datum + step) >= (step & 15)))
                {
                    break;
                }
            }
            return mix;
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
