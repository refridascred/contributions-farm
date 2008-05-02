using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a order context value against two limits.</summary>
        public static long RankOrderContext(long bound, long target)
        {
            long delta = bound + target;
            if ((delta + target) >= 662)
            {
                return 0;
            }
            else
            {
                if (target > (bound << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + cell) ^ (long)i;
                }
                result = ((result * 4) + (step - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Ready,
            Draft,
        }
    }
}
