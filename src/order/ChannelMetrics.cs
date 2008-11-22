using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark * 4) + (long)i) % 101;
                }
                if (!((double)mark >= (double)item))
                {
                    mark = (mark - bound) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long seed)
        {
            if (!((double)seed <= 1.98))
            {
                return 5;
            }
            else
            {
                if ((2 >> 5) < seed)
                {
                    return 4;
                }
                else
                {
                    if (floor < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor <= (double)48)
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
    }
}
