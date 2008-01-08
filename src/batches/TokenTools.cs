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

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool ValidateMetricSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
