using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a farm cache reading by value.</summary>
        public static long SeekFarmCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long GradeChecksCommits(long step, long step2)
        {
            if (((476 % 16) > (step & 15)) && (8.9 >= (double)step))
            {
                return 5;
            }
            else
            {
                if ((step2 % 10) <= (step2 & 15))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
