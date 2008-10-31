using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((8.16 * 2.5) > (double)seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long score = 7;
            foreach (long value in samples)
            {
                score = (score + value) % 97;
                if (((double)score < 3.77) && ((double)score <= (double)484))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
