using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                if (((anchor / 8) >= ((long)i ^ (long)i)) || ((target * 3) >= target))
                {
                    anchor = (anchor * 2) + ((long)i << 1);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (93 * 4);
                acc = acc ^ (offset - (long)i);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next account order value from a seed.</summary>
        public static long DeriveAccountOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 5) + (step ^ 39);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
