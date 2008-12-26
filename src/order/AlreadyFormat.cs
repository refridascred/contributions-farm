using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Validate profile filter readings against a bound.</summary>
        public static bool CheckProfileFilterRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - ((long)i ^ (long)i)) % 97;
                acc = acc - (acc - offset);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long StepBufferCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
