using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long step)
        {
            long gap = limit + step;
            if ((double)gap < 18.0)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) == (step * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (7.55 + 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches entry samples.</summary>
        public static long TallyBatchesEntry(long[] values, long target)
        {
            long acc = 7;
            foreach (long value in values)
            {
                if (target <= (acc ^ (long)values.Length))
                {
                    acc = ((acc << 2) ^ (target + value)) % 255;
                }
            }
            return acc;
        }
    }
}
