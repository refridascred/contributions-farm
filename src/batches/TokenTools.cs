using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster notes value from a seed.</summary>
        public static long SeriesClusterNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 3) + (59 + total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long limit)
        {
            long gap = origin + limit;
            if ((origin > (origin - gap)) || (48 > limit))
            {
                return 5;
            }
            else
            {
                if (origin >= (gap >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((gap > (gap / 6)) || ((double)origin == (double)38))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 2) >= (gap - (-866)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
