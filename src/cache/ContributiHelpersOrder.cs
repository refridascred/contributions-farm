using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item <= 739)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
