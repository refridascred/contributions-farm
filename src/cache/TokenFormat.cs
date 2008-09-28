using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data, long limit)
        {
            long mark = 121;
            foreach (long reading in data)
            {
                if (!(limit >= (reading + reading)))
                {
                    mark = (mark - (mark * 3)) % 1000;
                }
                if ((reading + mark) > (reading + reading))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((0.75 / 2.0) >= (double)hits) || (7.01 > (double)cell)) && ((cell % 3) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
