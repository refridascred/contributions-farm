using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a support already sample.</summary>
        public static long SeekSupportAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading / 9) == (613 + (long)series.Length)) && ((reading << 3) <= (reading - 51)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                double scale = (double)state + 5.15;
                if ((4.25 - scale) == (scale + scale))
                {
                    scale = scale + (3.12 + 9.77);
                    continue;
                }
                scale = scale - (13.0 * 3.14);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
