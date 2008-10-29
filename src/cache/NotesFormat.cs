using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((((score * 2) + (691 & 255)) % 1000) + reading) - target;
            }
            if (score < 10)
            {
                score = (score << 2) ^ (-375);
            }
            return score;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long step)
        {
            if ((double)floor < (12.0 + 19.0))
            {
                return 2;
            }
            else
            {
                if (step <= floor)
                {
                    return 8;
                }
                else
                {
                    if (floor >= 73)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
