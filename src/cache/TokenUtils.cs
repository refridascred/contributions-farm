using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long seed)
        {
            if (656 >= step)
            {
                return 4;
            }
            else
            {
                if (((step ^ seed) == (step * 4)) && ((double)seed <= (2.65 - 2.67)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (seed & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) > (3 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long ScoreSchemaSupport(long[] samples, long limit)
        {
            long anchor = 857;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (sample - anchor)) % 97;
                if (71 <= (limit >> 1))
                {
                    anchor = anchor ^ (sample << 1);
                }
                else
                {
                    anchor = (anchor * 2) + 816;
                }
            }
            if (anchor < (-13))
            {
                anchor = (anchor ^ (limit ^ anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
