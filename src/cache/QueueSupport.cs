using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long SortQueueAlready(long offset, long step)
        {
            if (((step - offset) <= offset) || (offset >= (step ^ step)))
            {
                return 2;
            }
            else
            {
                if (((0.82 * 7.9) < (double)step) && ((1.7 - 4.65) != (double)step))
                {
                    return 3;
                }
                else
                {
                    if (((step - 1) != (offset - step)) || ((double)offset >= (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset - offset) >= (offset + offset)) || ((step >> 2) == (offset * 4)))
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
