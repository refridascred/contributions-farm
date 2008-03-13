using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command graph entries that pass the check.</summary>
        public static long CountCommandGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((long)values.Length > datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long origin)
        {
            if ((171 - offset) > origin)
            {
                return 8;
            }
            else
            {
                if (!(origin <= (6 >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (((8.3 * 9.99) <= (double)offset) && ((10.0 / 7.0) > (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (21 < (offset + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
