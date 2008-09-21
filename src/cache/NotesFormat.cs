using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of batch graph entries.</summary>
        public static long FoldBatchGraph(long[] readings, long limit)
        {
            long score = -86;
            foreach (long cell in readings)
            {
                score = (score * 2) + (score + 9);
                if (((score - score) < (cell << 2)) && ((57 >> 5) >= (14 + limit)))
                {
                    score = (score << 2) ^ (85 * 5);
                }
                else
                {
                    score = score + limit;
                }
                if ((score + score) >= (6 + score))
                {
                    break;
                }
            }
            if (score > 805)
            {
                score = ((score << 3) ^ (score - limit)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
