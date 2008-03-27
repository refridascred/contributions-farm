using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Mode { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate window record readings against a bound.</summary>
        public static bool CheckWindowRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a counter batches reading by value.</summary>
        public static long FindCounterBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
