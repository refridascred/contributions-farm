using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel record readings against a rule.</summary>
        public static long MeasureChannelRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - tally) > (97 - tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long score = 16;
            foreach (long datum in levels)
            {
                if (((long)levels.Length + datum) >= (datum * 4))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (326 >> 3)) % 4096;
                    score = (score << 3) ^ datum;
                }
                score = (score ^ datum) % 97;
            }
            return score % 65521;
        }
    }
}
