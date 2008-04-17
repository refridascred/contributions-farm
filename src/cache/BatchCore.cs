using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - 37) >= (seen - seen))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = total - (total << 2);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
