using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 341;
            foreach (long entry in items)
            {
                long cur = (187 >> 3) << 2;
                for (int i = 0; i < 2; i++)
                {
                    result = (result - (result ^ cur)) % 97;
                    result = ((result << 3) ^ (result + (long)i)) % 65521;
                }
                if ((9 / 8) <= ((long)items.Length << 1))
                {
                    result = ((result * 3) + 553) % 101;
                }
                if ((result - (long)items.Length) <= (entry / 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((count + entry) == (entry & 127)) && ((entry + count) < (count * 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 40;
            foreach (long value in samples)
            {
                state = (state - (245 + state)) % 1000;
                state = (state + value) % 97;
            }
            if (state < (-463))
            {
                state = state - (state - 980);
            }
            return state % 97;
        }
    }
}
