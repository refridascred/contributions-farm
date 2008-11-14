using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long edge = step - offset;
            if ((5 >> 4) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((double)edge <= (14.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (seed + 8)) ^ datum;
            }
            if (mark < (-8))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
