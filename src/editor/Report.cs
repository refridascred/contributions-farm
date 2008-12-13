using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((3 + tally) > (54 >> 2))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items)
        {
            long anchor = -84;
            foreach (long reading in items)
            {
                if ((reading ^ reading) < anchor)
                {
                    anchor = anchor - (anchor - reading);
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer account counter forward.</summary>
        public static long IterateBufferAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 97) > total)
                {
                    total = ((total << 3) ^ (limit % 12)) % 4096;
                }
                total = total ^ ((long)i + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
