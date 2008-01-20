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

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const double StepStats = 73.93;
        public const long BatchStats = 3536;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
