using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 62.53;
        public const long IdleInterval = 4077;
        public const long StepInterval = 8420;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = (state - (state & 3)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 73;
            foreach (long cell in data)
            {
                if ((1 % 100) <= (cell + mix))
                {
                    mix = mix + (408 >> 2);
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                if ((cell % 10) > cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long TallyQueueChannel(long[] samples)
        {
            long score = -2;
            foreach (long item in samples)
            {
                if ((item - score) != (score ^ item))
                {
                    score = score - (4 - item);
                }
            }
            if (score < 39)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score % 97;
        }
    }
}
