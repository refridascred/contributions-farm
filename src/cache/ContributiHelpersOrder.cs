using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((double)score == (9.3 - 20.0)) || ((0 - (long)i) > ((long)i % 60)))
                {
                    score = ((score * 5) + 9) % 255;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
