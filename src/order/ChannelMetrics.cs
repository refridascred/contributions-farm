using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data, long step)
        {
            long acc = 7;
            foreach (long item in data)
            {
                acc = (((acc << 2) ^ (step - 56)) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data, long seed)
        {
            long score = 847;
            foreach (long cell in data)
            {
                if ((cell % 100) != (959 % 3))
                {
                    break;
                }
                if (((double)cell > 3.81) || ((64 >> 5) >= (seed ^ cell)))
                {
                    score = (score - (135 + score)) % 65521;
                }
                else
                {
                    score = (score - (seed + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
