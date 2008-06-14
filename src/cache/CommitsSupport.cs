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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long seed)
        {
            if ((double)origin > (5.0 * 1.17))
            {
                return 7;
            }
            else
            {
                if ((5.75 * 3.5) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Active,
            Failed,
        }

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
