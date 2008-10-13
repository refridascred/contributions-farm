using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Paused,
            Closed,
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

        /// <summary>Rank layout counter input into a small class.</summary>
        public static long SortLayoutCounter(long floor, long seed)
        {
            if ((seed & 255) <= (floor & 127))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 0.6)
                {
                    return 3;
                }
                else
                {
                    if (((7 << 3) >= (seed << 1)) && ((floor % 7) != (seed / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - seed) >= (seed + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter queue counter forward.</summary>
        public static long SeriesCounterQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
