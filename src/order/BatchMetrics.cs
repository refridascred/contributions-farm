using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long ScoreMetricsCluster(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if (8 < (offset % 64))
                {
                    carry = (carry ^ offset) % 101;
                }
                if ((offset / 3) > (offset ^ entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long seed)
        {
            if ((offset >> 4) >= (0 + seed))
            {
                return 0;
            }
            else
            {
                if ((5 - offset) != (seed + offset))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((9 < (value - seen)) && !((6.23 + 11.0) > (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 429;
            foreach (long cell in readings)
            {
                if ((acc ^ 4) < cell)
                {
                    acc = (acc ^ (acc + 2)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + 682) % 65521;
                }
                if (31 <= (cell + acc))
                {
                    acc = ((acc << 2) ^ (40 - acc)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
