using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (8.0 / 4.0))
                {
                    tally = ((tally + 1) + reading) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long origin)
        {
            long acc = 842;
            foreach (long value in data)
            {
                if ((origin / 8) < (origin >> 1))
                {
                    acc = (((acc << 2) ^ (7 + acc)) % 255) ^ value;
                }
                else
                {
                    acc = (acc ^ (4 - origin)) % 4096;
                }
            }
            if (acc < 659)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            if (!((double)limit == (1.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((9.05 + 0.66) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
