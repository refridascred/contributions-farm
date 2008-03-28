using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batch queue readings.</summary>
        public static long CompareBatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Compare every pair of format schema readings.</summary>
        public static long MatchFormatSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
