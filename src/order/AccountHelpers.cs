using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long origin, long step)
        {
            if ((double)origin != (double)2)
            {
                return 0;
            }
            else
            {
                if ((origin - step) > (57 << 2))
                {
                    return 3;
                }
                else
                {
                    if (((8.96 * 0.63) < (double)origin) && ((step >> 2) != (origin + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > (origin * 3)) || (step <= (origin % 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
