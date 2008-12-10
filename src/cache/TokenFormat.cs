using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long bound, long offset)
        {
            if (((offset & 15) == (bound + offset)) || ((double)bound > (double)35))
            {
                return 1;
            }
            else
            {
                if ((291 + offset) <= 8)
                {
                    return 6;
                }
                else
                {
                    if (bound >= (bound ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine buffer schema values into a single score.</summary>
        public static long TallyBufferSchema(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample / 2)) % 65521;
                if (((sample * 5) <= (sample & 7)) || ((60 - acc) < (962 + sample)))
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
