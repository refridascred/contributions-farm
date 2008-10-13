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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Stale,
            Pending,
            Active,
            Closed,
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
