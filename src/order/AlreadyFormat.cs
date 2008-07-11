using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token githubfarm value against two limits.</summary>
        public static long GradeTokenGithubfarm(long origin, long step)
        {
            if (!((step + step) > ((-10) << 2)))
            {
                return 4;
            }
            else
            {
                if (5 > (step * 5))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step / 6) != (origin * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the graph session series from a seed.</summary>
        public static long IterateGraphSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor + anchor) % 4096) ^ (long)i2;
                    anchor = ((anchor * 5) + (anchor >> 4)) % 4096;
                }
                anchor = ((anchor << 3) ^ anchor) % 101;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = ((anchor ^ (anchor ^ target)) % 4096) ^ (long)i3;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            New,
            Ready,
            Synced,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
