using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long step)
        {
            long anchor = 59;
            foreach (long cell in samples)
            {
                anchor = (anchor + (anchor + 16)) % 1000;
                anchor = (anchor - (anchor * 2)) % 65521;
                if (((cell / 8) >= anchor) || ((step + anchor) != (cell / 6)))
                {
                    anchor = anchor + step;
                }
                if ((step - cell) < step)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count counter window pairs that satisfy a relation.</summary>
        public static long MatchCounterWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels)
        {
            long sum = -27;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + (item + sum)) - (long)i;
                }
                sum = (sum << 3) ^ item;
                if ((double)item > (5.0 / 4.0))
                {
                    sum = sum + (sum + item);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series, long target)
        {
            long carry = 656;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + (target & 1)) % 1000;
                if ((double)carry <= (double)cell)
                {
                    break;
                }
            }
            if (carry > 938)
            {
                carry = (carry * 2) + (carry * 2);
            }
            return carry;
        }

        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long CountBufferOrderHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + limit) == (8 - seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics session input into a small class.</summary>
        public static long GradeMetricsSession(long limit, long step)
        {
            if (((9.21 - 9.0) > (double)limit) && (limit < (step + step)))
            {
                return 4;
            }
            else
            {
                if (step > limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
