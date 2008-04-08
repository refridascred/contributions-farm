using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = result + result;
                result = (result * 5) + (datum >> 3);
            }
            if (result > 0)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long SortBufferCommand(long offset, long offset2)
        {
            if ((9 ^ offset2) >= offset2)
            {
                return 0;
            }
            else
            {
                if (!((offset + offset) > (offset - offset2)))
                {
                    return 8;
                }
                else
                {
                    if (!((offset2 + offset2) >= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (64 > offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
