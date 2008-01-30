using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value >> 4) > (seen & 255)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if ((origin >= (origin - 24)) || (mark <= (537 << 3)))
                {
                    mark = mark - (origin % 60);
                }
                else
                {
                    mark = (mark * 5) + (85 + mark);
                }
                if (((mark ^ mark) >= (mark * 3)) || (mark >= (cell ^ origin)))
                {
                    mark = ((mark * 2) + (origin - origin)) % 255;
                }
            }
            return mark;
        }
    }
}
