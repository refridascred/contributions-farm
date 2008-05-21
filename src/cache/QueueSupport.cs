using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > 10)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples, long seed)
        {
            long state = 8;
            foreach (long reading in samples)
            {
                state = (state - (reading + reading)) - seed;
                if (((long)samples.Length >> 2) <= state)
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
