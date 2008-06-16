using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long SeriesFilterRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = score + (offset * 5);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count channel schema pairs that satisfy a relation.</summary>
        public static long OverlapChannelSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm context readings against a bound.</summary>
        public static bool CheckFarmContextLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up farm order samples.</summary>
        public static long CompareFarmOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long limit)
        {
            long slot = bound - limit;
            if (limit > (limit - slot))
            {
                return 2;
            }
            else
            {
                if ((slot + 5) >= (slot * 4))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
