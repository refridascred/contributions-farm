using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long MeasureStreamFarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) <= floor)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Failed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Count the metrics channel entries that pass the check.</summary>
        public static long MeasureMetricsChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) < 1)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
