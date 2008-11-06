using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long limit)
        {
            if ((double)limit > (5.0 + 3.9))
            {
                return 6;
            }
            else
            {
                if (!((9 / 2) == (limit - offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = (total ^ (entry & 15)) % 1000;
                total = total + (entry * 2);
                if ((double)entry >= (17.0 + 4.96))
                {
                    total = ((total << 3) ^ 520) % 101;
                }
                else
                {
                    total = (total - offset) % 255;
                }
                if ((total / 3) > entry)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total * 2) + (offset << 2)) % 101;
            }
            return total % 97;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if ((double)score >= (1.0 + 8.6))
                {
                    score = (score << 2) ^ cell;
                }
                else
                {
                    score = (score - (score >> 3)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
