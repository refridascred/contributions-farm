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

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
