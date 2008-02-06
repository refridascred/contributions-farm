using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool CheckProfileFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long offset)
        {
            if (limit >= 15)
            {
                return 8;
            }
            else
            {
                if ((offset >> 5) >= (205 * 3))
                {
                    return 4;
                }
                else
                {
                    if (offset < (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-616) > (offset / 7)) && ((limit * 5) != (offset + limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next editor session value from a seed.</summary>
        public static long DeriveEditorSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if (offset < ((long)i - 6))
                {
                    state = (state * 3) + (state + (long)i);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
