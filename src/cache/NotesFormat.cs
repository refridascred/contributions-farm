using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor stats readings against a bound.</summary>
        public static bool VerifyEditorStatsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long offset)
        {
            long sum = 23;
            foreach (long cell in series)
            {
                if ((double)offset >= (double)cell)
                {
                    sum = (sum ^ (sum - cell)) % 97;
                }
                if (((double)cell == (double)sum) || ((sum + sum) < cell))
                {
                    sum = ((sum * 4) + (offset - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine stream record values into a single score.</summary>
        public static long DigestStreamRecord(long[] samples)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (reading ^ reading)) % 1000;
                anchor = anchor + (2 ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
