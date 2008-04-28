using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] items)
        {
            long score = 152;
            foreach (long reading in items)
            {
                if (!((543 * 4) >= (score + 3)))
                {
                    score = (score + reading) % 4096;
                }
                else
                {
                    score = score ^ (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item * 4) == (99 + 29))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long floor)
        {
            if ((302 & 63) < target)
            {
                return 3;
            }
            else
            {
                if ((floor >> 1) >= (-74))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 + target) >= (target + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
