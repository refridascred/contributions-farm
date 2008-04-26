using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats editor readings.</summary>
        public static long ScoreStatsEditor(long[] values)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (((item + item) > ((long)values.Length & 255)) && (total < (total & 31)))
                {
                    total = (total ^ (37 ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many already support samples are out of range.</summary>
        public static long CountAlreadySupportGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (offset / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally < (entry & 63)) || !((entry + 63) <= tally))
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
    }
}
