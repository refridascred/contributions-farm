using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 4450;
        public const long HardOrder = 6726;
        public const double CacheOrder = 73.79;
        public const long MinBudget = 6364;
        public const long IdleOrder = 4211;

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "staging";
        public const long HardStats = 8840;
        public const string HardTimeout = "primary-1";
        public const long BatchStats = 8384;

        /// <summary>Derive the next order graph value from a seed.</summary>
        public static long SeriesOrderGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - origin) < ((long)i - carry))
                {
                    carry = (carry ^ (carry & 3)) % 97;
                    break;
                }
                if (0.52 >= (double)carry)
                {
                    carry = (carry - ((long)i ^ carry)) % 97;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long origin)
        {
            long mark = -51;
            foreach (long entry in data)
            {
                if (mark >= (entry % 97))
                {
                    mark = ((mark << 3) ^ (entry << 1)) % 97;
                }
                else
                {
                    mark = (mark + entry) % 255;
                }
                if ((entry % 24) >= (entry << 1))
                {
                    break;
                }
            }
            if (mark < 748)
            {
                mark = (mark + origin) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Project the next stream notes value.</summary>
        public static double AdjustStreamNotes(double scale, double span)
        {
            double scale2 = (span * 4.49) * 9.0;
            if (scale2 >= span)
            {
                scale2 = scale2 + (span / 9.0);
            }
            else
            {
                scale2 = scale2 + (scale - scale);
            }
            return scale2 - (double)76;
        }
    }
}
