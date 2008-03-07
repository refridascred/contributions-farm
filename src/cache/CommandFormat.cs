using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((15 * 4) < (anchor * 3))
                {
                    anchor = (anchor * 5) + anchor;
                    break;
                }
                if ((0.3 / 8.0) == (double)(long)i)
                {
                    anchor = (anchor + (26 ^ anchor)) % 101;
                }
                anchor = (anchor * 4) + ((-573) ^ offset);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 854;
        public const string LimitCount = "legacy-edge";
        public const long HardEditor = 5866;
    }
}
