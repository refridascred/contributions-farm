using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (((offset + bound) > (offset ^ bound)) || (0 < (bound2 % 5)))
            {
                return 5;
            }
            else
            {
                if ((bound * 5) == (offset + 9))
                {
                    return 6;
                }
                else
                {
                    if (bound2 < 33)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if ((mix ^ 75) != ((long)i + (long)i))
                {
                    mix = (mix ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
