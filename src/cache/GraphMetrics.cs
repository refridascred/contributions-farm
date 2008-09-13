using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of record entry readings.</summary>
        public static long PairRecordEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long TallyStreamTokenMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen == (double)offset) || ((616 + offset) != (reading + offset)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 1;
            foreach (long value in samples)
            {
                result = (result - (0 & 1)) % 255;
                if ((71 - value) >= 71)
                {
                    result = ((result * 2) + (result << 2)) % 4096;
                }
                else
                {
                    result = result + value;
                }
            }
            if (result < 840)
            {
                result = result - (result - 3);
            }
            return result % 4096;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
