using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((bound - sample) > (sample >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long floor)
        {
            if ((61 % 24) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if (floor < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
