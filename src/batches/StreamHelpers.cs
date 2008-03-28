using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long acc = 97;
            foreach (long value in readings)
            {
                if (value <= acc)
                {
                    acc = acc - (61 + acc);
                }
                else
                {
                    acc = acc - (value / 4);
                }
            }
            if (acc < (-26))
            {
                acc = (acc ^ (acc * 5)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long limit)
        {
            if (seed < (766 ^ limit))
            {
                return 6;
            }
            else
            {
                if (!((limit >> 2) < (limit - seed)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
