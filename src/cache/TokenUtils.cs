using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long sum = 3;
            foreach (long cell in series)
            {
                if (step > (cell / 8))
                {
                    sum = (sum ^ step) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
            }
            if (sum < 3)
            {
                sum = sum - (591 + sum);
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 ^ hits) >= (reading % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
