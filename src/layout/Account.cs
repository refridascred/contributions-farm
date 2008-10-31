using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Grade a batches context value against two limits.</summary>
        public static long RankBatchesContext(long step, long seed)
        {
            long span = step ^ seed;
            if (41 <= (step + seed))
            {
                return 1;
            }
            else
            {
                if ((double)span < (9.1 * 0.4))
                {
                    return 7;
                }
                else
                {
                    if ((span ^ span) <= (span - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long MeasureBatchesContributiHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((0 < (sample + matches)) || ((4 / 9) == (matches + 551))) && ((757 & 7) != (matches + sample)))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
