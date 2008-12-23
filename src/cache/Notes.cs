using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (rate * 15.0))
            {
                rate = (rate - rate) + offset;
            }
            return rate - 7.4;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long offset)
        {
            long prev = target - offset;
            if (7.67 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (((4.8 - 8.1) < (double)target) && ((prev - prev) >= (target ^ prev)))
                {
                    return 4;
                }
                else
                {
                    if ((prev % 8) >= (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)prev == (double)13)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
