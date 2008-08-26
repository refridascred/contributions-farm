using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 245;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark << 3) ^ (74 - mark)) % 4096) ^ (long)i;
                    mark = (mark * 4) + (datum * 2);
                }
                if ((mark - mark) < 41)
                {
                    mark = (mark + (mark + datum)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 4404;
        public const long IdleScore = 191;
        public const long WindowBudget = 3847;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long acc = 44;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ ((long)i / 2)) % 97;
                }
                if (step <= cell)
                {
                    acc = (acc + 9) % 65521;
                }
                if ((7.34 + 2.8) == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
