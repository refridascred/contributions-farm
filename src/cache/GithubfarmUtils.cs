using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cluster format value against two limits.</summary>
        public static long ClassifyClusterFormat(long limit, long step)
        {
            long slot = limit ^ step;
            if ((20 >= (slot + limit)) && ((step * 5) >= (limit + 189)))
            {
                return 8;
            }
            else
            {
                if (((slot / 5) <= (step / 7)) && ((double)limit <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 1) > 892)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + step) <= (step ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
