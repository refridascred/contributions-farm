using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if ((5.79 * 9.0) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if (!(20 < (step << 1)))
                {
                    return 8;
                }
                else
                {
                    if (!(step >= (origin / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= (1.71 + 14.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long target)
        {
            long mark = -43;
            foreach (long entry in readings)
            {
                if (!(target > (long)readings.Length))
                {
                    mark = (mark + (mark / 6)) % 255;
                }
                if ((entry % 8) != (925 + target))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 3) ^ (mark + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (target >> 3);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
