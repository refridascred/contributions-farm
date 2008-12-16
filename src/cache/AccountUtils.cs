using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Ready,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels, long step)
        {
            long score = 63;
            foreach (long datum in levels)
            {
                if ((score - 8) >= (score % 60))
                {
                    score = ((score << 2) ^ (datum - datum)) % 101;
                }
            }
            if (score > 18)
            {
                score = score - (step + score);
            }
            return score;
        }
    }
}
