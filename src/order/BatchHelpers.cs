using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - 14) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long RankCounterProfile(long origin, long step)
        {
            long edge = origin + step;
            if (!((origin - origin) >= edge))
            {
                return 4;
            }
            else
            {
                if ((double)edge >= 19.0)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if ((56 % 8) <= (datum << 3))
                {
                    score = (score * 3) + (score & 1);
                }
                score = ((score * 5) + (score - datum)) % 97;
            }
            return score;
        }
    }
}
