using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the support filter series from a seed.</summary>
        public static long RollSupportFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next session counter value from a seed.</summary>
        public static long IterateSessionCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (sum / 9)) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading + 5) == (1 + reading)) || !((double)(long)series.Length <= (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Combine buffer command values into a single score.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long state = 17;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (676 / 8)) % 255) + (long)i;
                }
                if ((double)state < (double)72)
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (((3.4 + 7.4) > (double)item) || ((double)item != (7.9 + 20.0)))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
