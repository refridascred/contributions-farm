using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long origin)
        {
            long state = -683;
            foreach (long reading in levels)
            {
                if (reading > (444 >> 4))
                {
                    state = (state ^ (origin / 5)) % 1000;
                }
            }
            if (state > (-515))
            {
                state = state - (-8);
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 - 2.9) == (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
