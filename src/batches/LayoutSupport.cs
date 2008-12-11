using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank githubfarm contributi input into a small class.</summary>
        public static long GradeGithubfarmContributi(long limit, long target)
        {
            if (46 < (limit >> 2))
            {
                return 1;
            }
            else
            {
                if ((536 % 60) < limit)
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (7.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long score = 99;
            foreach (long cell in levels)
            {
                score = ((score * 3) + (cell * 3)) % 4096;
                if ((cell * 5) == (cell - score))
                {
                    score = (score + (score - (-475))) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long IterateFilterMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
