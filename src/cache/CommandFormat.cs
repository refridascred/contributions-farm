using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (179 % 97)) % 97;
                state = (state << 2) ^ (state ^ state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Classify a profile contributi pair into a bucket.</summary>
        public static long SortProfileContributi(long origin, long step)
        {
            if (step > (origin >> 4))
            {
                return 4;
            }
            else
            {
                if (((step ^ step) > (step ^ origin)) || ((origin << 2) <= origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) == (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= (step >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}
