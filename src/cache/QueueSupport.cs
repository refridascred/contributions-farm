using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long floor)
        {
            long prev = step - floor;
            if ((double)step > (double)floor)
            {
                return 0;
            }
            else
            {
                if (942 < (627 - prev))
                {
                    return 5;
                }
                else
                {
                    if ((step <= (prev & 15)) || ((step >> 2) >= (step ^ prev)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((150 >> 1) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a entry already counter forward.</summary>
        public static long DeriveEntryAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ (floor ^ (long)i)) % 255;
                state = (state * 3) + (state - 64);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
