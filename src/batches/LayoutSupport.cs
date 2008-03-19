using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long step)
        {
            if (step <= (step << 2))
            {
                return 7;
            }
            else
            {
                if ((step & 127) < (step / 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            long slot = target ^ target2;
            if (((target + target) < (target2 + target2)) || ((target2 + 8) <= (slot - slot)))
            {
                return 5;
            }
            else
            {
                if ((slot + 82) >= (2 & 63))
                {
                    return 7;
                }
                else
                {
                    if (((slot + 128) != (2 - 803)) && ((target - 47) < (287 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 + target2) >= (target * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Locked,
            Draft,
        }
    }
}
