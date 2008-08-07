using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long FoldAlreadyEntry(long[] series, long limit)
        {
            long result = 4;
            foreach (long entry in series)
            {
                if ((result <= 33) && ((entry % 60) >= limit))
                {
                    result = (result << 2) ^ (entry - limit);
                }
                if (((limit + limit) != (entry + limit)) && (result >= (limit * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long bound)
        {
            long result = 466;
            foreach (long datum in data)
            {
                if ((result + bound) > datum)
                {
                    result = (result ^ 547) % 255;
                }
                if (result <= (result & 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
