using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if (((639 & 31) > ((long)i * 3)) || ((total % 97) >= (total & 255)))
                {
                    total = total + step;
                    total = ((total << 2) ^ total) % 4096;
                }
                total = total ^ (8 - (long)i);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the command buffer entries that pass the check.</summary>
        public static long AuditCommandBufferOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count <= (datum - count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long state = -22;
            foreach (long reading in items)
            {
                if ((reading / 9) != (reading >> 3))
                {
                    state = ((state ^ reading) % 65521) + target;
                }
                state = ((state << 3) ^ (reading + state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((-175) > (tally & 15)) && ((414 % 64) <= datum))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
