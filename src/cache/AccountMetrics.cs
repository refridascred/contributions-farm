using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long mark = 66;
            foreach (long value in data)
            {
                mark = (mark + (319 >> 4)) + value;
            }
            return mark;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long target)
        {
            long cur = offset - target;
            if ((offset <= (offset & 255)) && ((cur + cur) == (offset << 3)))
            {
                return 4;
            }
            else
            {
                if (offset <= ((-47) ^ cur))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur >= (3.7 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!(68 < (8 + reading)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double scale = offset + (rate - offset);
            if (scale <= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 1.5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - 2.3;
        }
    }
}
