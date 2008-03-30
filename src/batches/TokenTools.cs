using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length + count) < 8) && ((count + 8) != (datum - datum)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (666 > bound)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
