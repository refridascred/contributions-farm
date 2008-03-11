using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long origin)
        {
            long step = bound + origin;
            if ((origin << 1) < bound)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long RankGraphCounter(long origin, long floor)
        {
            if ((floor + origin) >= (origin + floor))
            {
                return 5;
            }
            else
            {
                if (((-58) - origin) < floor)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (origin - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
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
