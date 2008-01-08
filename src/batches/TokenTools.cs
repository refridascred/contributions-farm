using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token editor entries.</summary>
        public static long DigestTokenEditor(long[] values)
        {
            long carry = 823;
            foreach (long datum in values)
            {
                carry = ((carry ^ (carry * 5)) % 65521) + datum;
            }
            if (carry < 31)
            {
                carry = ((carry * 4) + (carry - 473)) % 255;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count << 2) == (datum >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)seen >= 16.0) && (((long)readings.Length ^ value) > (value + bound)))
                {
                    seen = seen + 1;
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
