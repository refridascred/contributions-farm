using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < (tally % 12))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit / 3) < ((long)items.Length + hits))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry record reading.</summary>
        public static double SmoothEntryRecord(double gain, double bias)
        {
            double drift = 2.0 * 6.67;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (9.0 + gain)) + (double)(long)i) + bias;
            }
            return drift - gain;
        }
    }
}
