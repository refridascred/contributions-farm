using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound >> 4) < (mark / 9))
                {
                    mark = mark + (bound & 31);
                }
                else
                {
                    mark = (mark - ((long)i + 2)) % 101;
                }
                mark = ((mark << 2) ^ (2 & 7)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(47 > (reading * 2)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
