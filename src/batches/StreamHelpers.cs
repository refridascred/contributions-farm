using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long offset)
        {
            if (!((double)offset != (4.6 - 7.0)))
            {
                return 5;
            }
            else
            {
                if ((offset < (586 % 100)) || (floor >= offset))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 2) < (floor % 24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long DeriveTokenBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                if ((state >= (state >> 2)) && ((87 & 3) > step))
                {
                    state = ((state << 3) ^ step) % 4096;
                    state = state - (step % 5);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Queued,
            Active,
            Pending,
            Ready,
        }
    }
}
