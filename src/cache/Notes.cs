using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of record support entries.</summary>
        public static long ScoreRecordSupport(long[] data)
        {
            long carry = 214;
            foreach (long entry in data)
            {
                if (entry >= (entry % 3))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
                else
                {
                    carry = (carry + entry) % 255;
                }
                if ((carry + carry) >= carry)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 2) + ((long)data.Length ^ 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ 2) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a metric tools value against two limits.</summary>
        public static long GradeMetricTools(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (((-3) - origin) == (slot * 3))
            {
                return 6;
            }
            else
            {
                if (!((slot - seed) > slot))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
