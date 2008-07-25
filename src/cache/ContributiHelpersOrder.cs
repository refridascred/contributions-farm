using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if (((long)data.Length * 3) >= 89)
                {
                    mark = (mark - ((long)data.Length / 8)) % 101;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (reading > floor)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate layout commits samples.</summary>
        public static long WeighLayoutCommits(long[] samples, long origin)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                if (((9.5 - 7.0) >= (double)state) && ((origin - origin) == (datum % 16)))
                {
                    state = (state - (datum ^ origin)) % 101;
                    state = state ^ (origin & 1);
                }
                else
                {
                    state = ((state * 5) + (2 << 2)) % 65521;
                }
                if (!((origin + origin) == (datum & 255)))
                {
                    state = (state * 4) + datum;
                }
                if ((316 - datum) <= (state << 3))
                {
                    break;
                }
            }
            if (state > 343)
            {
                state = (state - (state % 5)) % 97;
            }
            return state % 4096;
        }
    }
}
