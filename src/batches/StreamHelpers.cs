using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Pending,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (8.6 < (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long floor)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if ((4.8 + 4.34) != (double)floor)
                {
                    result = ((result * 3) + (910 + 633)) % 65521;
                    result = ((result << 2) ^ (datum - 47)) % 255;
                }
                else
                {
                    result = (result * 3) + (result + result);
                }
                if (7 > result)
                {
                    result = (result ^ (floor ^ datum)) % 101;
                }
                else
                {
                    result = (result - (4 + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
