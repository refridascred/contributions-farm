using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long origin)
        {
            long mix = 94;
            foreach (long entry in readings)
            {
                if ((6.7 / 7.0) != (double)mix)
                {
                    mix = (mix ^ (4 - (-4))) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (origin + entry)) % 1000;
                }
                if ((origin - mix) == (395 >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (5.7 * 0.6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
