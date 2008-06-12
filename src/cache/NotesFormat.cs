using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long step = origin ^ seed;
            if (((-78) + seed) >= (step / 7))
            {
                return 3;
            }
            else
            {
                if ((origin >> 3) == (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 7) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((882 * 5) < (113 - step))
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (8.7 - 3.0))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
