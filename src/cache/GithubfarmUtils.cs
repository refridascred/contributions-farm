using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long origin)
        {
            long anchor = 453;
            foreach (long value in data)
            {
                anchor = (anchor ^ value) % 255;
                if (((-402) - 7) > (anchor - value))
                {
                    anchor = (anchor - (0 + (-6))) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value - origin)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long SortProfileChecks(long origin, long target)
        {
            if (!(origin >= target))
            {
                return 2;
            }
            else
            {
                if ((4.7 / 9.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((target % 60) < target) && (target <= (839 << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 48) != (364 - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
