using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data)
        {
            long acc = 609;
            foreach (long datum in data)
            {
                if (acc > (838 >> 3))
                {
                    acc = (((acc * 4) + (87 - acc)) % 65521) - datum;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5241;
        public const double SoftInterval = 52.53;
        public const long MinStats = 1024;

        /// <summary>Iterate the counter layout series from a seed.</summary>
        public static long StepCounterLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score ^ (989 * 5)) % 255) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
