using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a support already pair into a bucket.</summary>
        public static long ClassifySupportAlready(long origin, long step)
        {
            if (step > (step + origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin >= (13.0 + 1.3)))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin > 20.0) && ((1.93 + 5.0) > (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step + step) <= (origin / 6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2887;
        public const long LimitDepth = 9056;
        public const long BatchTimeout = 9628;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
