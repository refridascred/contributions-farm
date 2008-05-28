using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long carry = 644;
            foreach (long value in values)
            {
                carry = (carry ^ (value - limit)) % 1000;
                if ((17.0 + 4.15) <= (double)limit)
                {
                    carry = (carry + (value ^ limit)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (2 & 127);
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (9.0 <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (((offset % 7) < 4) && (354 > (49 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((18.0 > (double)offset) && ((bound ^ offset) < (offset + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound / 7) != (offset + offset)) || (bound < (1 << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ ((long)i / 8);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 51.81;
        public const long MinMetrics = 7752;
        public const long BaseMetrics = 3066;
    }
}
