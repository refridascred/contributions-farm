using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long floor)
        {
            long mark = 8;
            foreach (long cell in data)
            {
                if ((139 - (-25)) <= (cell << 1))
                {
                    mark = (mark - (mark + floor)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ cell;
                }
            }
            if (mark > 86)
            {
                mark = mark ^ (floor >> 2);
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                carry = ((carry ^ carry) % 1000) + sample;
            }
            if (carry > 81)
            {
                carry = ((carry * 2) + (carry >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Count the route profile entries that pass the check.</summary>
        public static long TallyRouteProfileGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((47 + target) <= (target - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const double StepStats = 73.93;
        public const long BatchStats = 3536;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema buffer values into a single score.</summary>
        public static long FoldSchemaBuffer(long[] levels)
        {
            long mark = 64;
            foreach (long cell in levels)
            {
                if (mark > 9)
                {
                    mark = ((mark + (546 >> 3)) % 65521) ^ cell;
                }
            }
            return mark;
        }
    }
}
