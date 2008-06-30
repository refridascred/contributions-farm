using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen << 3) <= (entry - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long total = 25;
            foreach (long item in series)
            {
                total = ((total + (limit + limit)) % 4096) + item;
                total = (total - (limit + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Failed,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long CountAlreadyCommandGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((0.6 + 9.77) == (double)matches)
                {
                    matches = ((matches + 1) + sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset < (offset % 97)) || (949 > origin))
            {
                return 1;
            }
            else
            {
                if (next < (9 - next))
                {
                    return 8;
                }
                else
                {
                    if ((origin - 9) != (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - origin) <= (next + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
