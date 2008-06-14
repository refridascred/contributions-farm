using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long floor)
        {
            if (floor > (target << 2))
            {
                return 4;
            }
            else
            {
                if (8 > (target / 4))
                {
                    return 1;
                }
                else
                {
                    if (target > 53)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                if (anchor <= (sample + anchor))
                {
                    anchor = (anchor - sample) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank order entry input into a small class.</summary>
        public static long GradeOrderEntry(long target, long origin)
        {
            long step = target ^ origin;
            if ((step * 5) != (target % 12))
            {
                return 7;
            }
            else
            {
                if (3 < (target & 127))
                {
                    return 2;
                }
                else
                {
                    if (0.4 < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 3381;
        public const long HardInterval = 8251;
        public const long CacheRatio = 3272;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
