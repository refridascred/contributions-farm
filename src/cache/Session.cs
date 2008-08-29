using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((offset + offset) >= 815)
            {
                return 5;
            }
            else
            {
                if ((slot << 2) > (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)9 != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
