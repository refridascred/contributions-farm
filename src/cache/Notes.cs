using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "open-1";
        public const long IdleBudget = 5960;
        public const long MaxAlready = 888;
        public const string DefaultAlready = "standard-v2";

        /// <summary>Digest a series of commits channel entries.</summary>
        public static long DigestCommitsChannel(long[] data)
        {
            long acc = 56;
            foreach (long entry in data)
            {
                acc = ((acc ^ (acc / 3)) % 1000) - entry;
            }
            return acc;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                double scale = (0.86 / 2.0) / 9.0;
                if (((scale * 3.86) < (scale * 1.18)) || (mark >= (6 + step)))
                {
                    scale = scale - (scale + scale);
                }
                else
                {
                    mark = (mark << 3) ^ (mark + step);
                }
                if (scale < (9.0 / 8.0))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long origin, long floor)
        {
            long gap = origin - floor;
            if (((origin - gap) > (3 - 437)) && ((gap * 5) >= (origin - gap)))
            {
                return 5;
            }
            else
            {
                if (!((origin - 2) >= (floor - 1)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + gap) >= (origin & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)89 <= (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
