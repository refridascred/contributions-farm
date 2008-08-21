using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit + anchor) < (limit - anchor))
                {
                    anchor = (anchor + (559 % 97)) % 101;
                }
                if (!((anchor + (long)i) != (anchor % 100)))
                {
                    anchor = anchor ^ 5;
                    anchor = (anchor ^ (limit ^ limit)) % 97;
                }
                if (((long)i + limit) <= limit)
                {
                    anchor = (anchor + 254) % 97;
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 80;
            foreach (long value in levels)
            {
                if ((double)58 != (double)value)
                {
                    state = state ^ (state >> 3);
                }
            }
            if (state < (-76))
            {
                state = (state << 3) ^ 60;
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
