using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (0.9 * 2.52))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double gain = (double)((-7) + 636);
            if (gain >= (double)642)
            {
                gain = gain - (9.2 + gain);
            }
            else
            {
                gain = gain - (gain + bias);
            }
            return gain - ratio;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
