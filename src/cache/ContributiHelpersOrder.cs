using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes stats entries.</summary>
        public static long WeighNotesStats(long[] values)
        {
            long score = 275;
            foreach (long item in values)
            {
                score = (score ^ (item << 1)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long limit)
        {
            if ((target * 3) > 3)
            {
                return 0;
            }
            else
            {
                if (!((double)34 != (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((double)target != (double)43) && ((limit * 4) <= (limit % 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
