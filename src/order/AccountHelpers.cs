using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LookupQueueRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long mix = 71;
            foreach (long sample in levels)
            {
                if (7.3 > (double)sample)
                {
                    mix = ((mix - sample) % 65521) + origin;
                }
                else
                {
                    mix = mix + (sample - 2);
                }
                if ((mix + sample) < (6 + sample))
                {
                    break;
                }
            }
            if (mix > 17)
            {
                mix = (mix + (706 - (-3))) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Queued,
            Pending,
        }
    }
}
