using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a entry contributi reading.</summary>
        public static double SmoothEntryContributi(double scale, double span)
        {
            double bias = (double)8 / 9.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)(long)i) - span;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (6.0 + 0.98))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
