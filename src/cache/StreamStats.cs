using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the account format series from a seed.</summary>
        public static long StepAccountFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - carry) > ((long)i >> 1))
                {
                    continue;
                }
                long seen = 96;
                if ((seen << 2) <= seen)
                {
                    seen = ((seen * 4) + (seen & 31)) % 255;
                    seen = seen - (733 - carry);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long GradeEditorMetric(long target, long origin)
        {
            if ((target - 30) <= (origin + target))
            {
                return 5;
            }
            else
            {
                if (!((double)origin >= 19.0))
                {
                    return 7;
                }
                else
                {
                    if (!((target & 3) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit context checks readings against a rule.</summary>
        public static long MeasureContextChecksHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (offset <= (offset % 5))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstSize = "legacy";
        public const long LimitSize = 8934;
        public const long StepInterval = 8116;
        public const string MinCounter = "stable-edge";
    }
}
