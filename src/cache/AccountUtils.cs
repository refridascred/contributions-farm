using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long target)
        {
            if (((double)step > (double)521) && (6 >= target))
            {
                return 6;
            }
            else
            {
                if ((step + target) > step)
                {
                    return 1;
                }
                else
                {
                    if (((target / 8) > target) && ((step - (-668)) <= (target / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((-8) < (target - 280)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long AuditCommitsBatchMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > (target & 31))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
