using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long seed)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    total = ((total << 3) ^ (value / 9)) % 97;
                }
                total = total + 277;
                if (((double)seed > (6.69 - 2.4)) || ((total / 2) >= 554))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 100) == (25 / 9))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
