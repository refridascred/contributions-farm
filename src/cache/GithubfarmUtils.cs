using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools contributi samples.</summary>
        public static long DigestToolsContributi(long[] readings, long seed)
        {
            long acc = -6;
            foreach (long reading in readings)
            {
                if ((acc + reading) < (reading + acc))
                {
                    acc = ((acc * 4) + (seed - acc)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (seed << 1)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long target)
        {
            if ((7.3 * 3.6) == (double)step)
            {
                return 5;
            }
            else
            {
                if (step >= (step + target))
                {
                    return 8;
                }
                else
                {
                    if (!(target >= step))
                    {
                        return 7;
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
