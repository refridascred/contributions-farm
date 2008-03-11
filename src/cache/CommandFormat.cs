using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate format command readings against a bound.</summary>
        public static bool CheckFormatCommandRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long DeriveToolsChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result + step) % 65521;
                if (((long)i + result) >= (result << 2))
                {
                    result = ((result << 2) ^ step) % 1000;
                    result = (result + (step << 1)) % 65521;
                    continue;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long target)
        {
            long bound2 = bound ^ target;
            if (bound <= (bound << 2))
            {
                return 2;
            }
            else
            {
                if (((target / 6) == (target - bound2)) && ((92 + bound2) != (bound2 % 3)))
                {
                    return 3;
                }
                else
                {
                    if ((82 + target) <= (30 + 554))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
