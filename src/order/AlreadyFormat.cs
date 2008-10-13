using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long state = 16;
            foreach (long item in samples)
            {
                if ((755 & 63) >= (state - state))
                {
                    state = (state + (state & 3)) ^ item;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 2) ^ (floor - (long)i);
                long step = score;
                if (!(((step + floor) >= floor) && (6 <= (step / 3))))
                {
                    step = (step - score) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine route queue values into a single score.</summary>
        public static long TotalRouteQueue(long[] values, long target)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = score ^ (-987);
                if (!((datum + 454) >= (target + target)))
                {
                    score = (score * 4) + (datum - score);
                }
            }
            if (score < 217)
            {
                score = (score - (792 + 574)) % 101;
            }
            return score % 97;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long origin)
        {
            if (origin < (404 ^ origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit != (18.0 - 6.92))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.8 < (double)origin) || (13 >= (origin & 31)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Closed,
            Pending,
        }
    }
}
