using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long ClassifyGraphChecks(long target, long limit)
        {
            if (!((double)target != (double)(-5)))
            {
                return 6;
            }
            else
            {
                if ((limit & 15) > (943 - limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit >= (target ^ target)) || ((double)limit < (8.23 + 9.3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + target) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i > 5.0)
                {
                    state = state ^ (state % 64);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
