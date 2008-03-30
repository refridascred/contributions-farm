using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally < (tally - tally)) || ((3.1 / 9.0) > (double)tally)) || (tally < 736))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value >> 3) > (long)data.Length)
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
