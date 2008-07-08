using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit + (-83)) != (limit % 10))
                {
                    state = (state ^ ((long)i ^ state)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + offset) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long offset, long step)
        {
            long next = offset - step;
            if (next >= (offset / 7))
            {
                return 5;
            }
            else
            {
                if (((step << 1) >= (step - step)) && ((step * 2) >= (next << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((next - offset) != (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((9.4 - 8.0) != (double)next) && (3.6 > (double)next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up account context samples.</summary>
        public static long CompareAccountContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = total + (cell << 2);
                if ((total + 440) == (total * 2))
                {
                    total = (total - (cell >> 5)) % 65521;
                }
                total = (total << 2) ^ (968 & 15);
            }
            return total % 1000;
        }
    }
}
