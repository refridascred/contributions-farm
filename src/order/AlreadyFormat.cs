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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score - ((long)i << 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
