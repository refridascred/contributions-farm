using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long target)
        {
            long total = 284;
            foreach (long sample in samples)
            {
                if ((2.06 * 0.8) != (double)target)
                {
                    total = (total * 2) + (target >> 3);
                }
                if (sample >= (sample >> 3))
                {
                    total = (total + ((-62) + sample)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (total - 572)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch payload entry stays within the limit.</summary>
        public static bool GuardBatchPayloadBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
