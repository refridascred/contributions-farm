using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long step)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = ((total ^ (74 & 3)) ^ entry) - step;
                if ((16.0 / 6.0) != (double)total)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryScore = 1784;
        public const double SoftRatio = 19.7;
        public const long WindowBudget = 5492;
        public const long LimitTimeout = 574;
        public const long CacheDepth = 5127;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = (score + origin) % 255;
                score = ((score * 5) + (score / 7)) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
