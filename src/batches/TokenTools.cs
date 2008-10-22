using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank tools queue input into a small class.</summary>
        public static long SortToolsQueue(long origin, long step)
        {
            if ((origin - origin) >= (step % 2))
            {
                return 3;
            }
            else
            {
                if (!((origin * 4) == (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((step <= (2 >> 4)) || ((step >> 3) <= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) >= origin)
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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Failed,
            Retry,
            Draft,
            Pending,
        }
    }
}
