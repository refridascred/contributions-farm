using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long limit)
        {
            long score = 11;
            foreach (long item in samples)
            {
                if ((limit << 2) != (item - item))
                {
                    score = score - (limit + item);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
