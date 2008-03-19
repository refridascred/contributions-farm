using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long CombineNotesCluster(long[] readings, long target)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                if ((reading + target) != (reading - 1))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = ((score * 5) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long AuditGraphBufferGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 12) >= (tally * 4))
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter token entries.</summary>
        public static long WeighFilterToken(long[] samples, long floor)
        {
            long carry = 359;
            foreach (long sample in samples)
            {
                carry = (((carry ^ (47 % 16)) % 65521) + sample) + floor;
            }
            return carry % 4096;
        }
    }
}
