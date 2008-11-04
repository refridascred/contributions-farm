using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate format batches samples.</summary>
        public static long ScoreFormatBatches(long[] samples)
        {
            long state = -8;
            foreach (long reading in samples)
            {
                state = ((state * 3) + (reading ^ state)) % 1000;
                if (((2 - state) <= (long)samples.Length) && ((1 + reading) > (6 << 1)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values)
        {
            long state = 2;
            foreach (long entry in values)
            {
                state = (state ^ (state + entry)) % 255;
                if ((entry * 2) != (entry + 942))
                {
                    state = (state ^ (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinLevel = 3.55;
        public const double HardCount = 89.73;
        public const long CacheFarm = 8482;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6450;
        public const double IdleSize = 24.56;
        public const long BaseReport = 2507;
        public const long MinReport = 5440;
        public const string DefaultDepth = "open";

        /// <summary>Find the first channel farm entry that matches the target.</summary>
        public static long LocateChannelFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
