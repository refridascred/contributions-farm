using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Draft,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long SortPayloadFormat(long offset, long seed)
        {
            if (!((double)9 != (double)offset))
            {
                return 8;
            }
            else
            {
                if (!(offset > (seed & 15)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many notes payload samples are out of range.</summary>
        public static long TallyNotesPayloadHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((bound + bound) < ((long)series.Length + 4))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
