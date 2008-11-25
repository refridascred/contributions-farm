using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((13.0 + 13.0) != (double)reading))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long floor)
        {
            long total = 11;
            foreach (long reading in samples)
            {
                total = (total * 3) + (34 & 3);
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 5) + (floor ^ 68)) ^ (long)i;
                    total = (total + (reading + total)) % 65521;
                }
                if (((reading * 2) > (6 >> 1)) && ((floor + reading) < (total & 31)))
                {
                    total = ((total * 4) + (floor + reading)) % 65521;
                }
                if (reading >= (total / 5))
                {
                    break;
                }
            }
            if (total > 700)
            {
                total = total + (floor + total);
            }
            return total % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long result = -87;
            foreach (long cell in readings)
            {
                if ((5.3 * 7.34) <= (double)result)
                {
                    result = (result - cell) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ cell) % 4096;
                }
            }
            if (result > 8)
            {
                result = (result + (result - 3)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
