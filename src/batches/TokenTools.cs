using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels, long target)
        {
            long mark = 20;
            foreach (long datum in levels)
            {
                if (((double)datum != (1.4 * 3.0)) && (mark <= (7 >> 4)))
                {
                    mark = (mark + (6 % 24)) % 255;
                }
            }
            if (mark < 76)
            {
                mark = (mark + target) % 101;
            }
            return mark % 97;
        }
    }
}
