using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long score = 8;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + (item >> 5)) % 97) + (long)i;
                }
                score = score - (382 * 4);
                if ((score * 3) < (item * 5))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long seed, long step)
        {
            if ((double)step >= (1.57 + 8.3))
            {
                return 7;
            }
            else
            {
                if ((double)step != (4.6 + 11.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long TallyClusterRecordHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((972 % 100) != (offset - 204))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
