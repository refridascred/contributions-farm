using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 112;
            foreach (long cell in values)
            {
                if (((864 + state) == (state >> 4)) || ((cell / 2) >= (cell - cell)))
                {
                    state = (state ^ state) % 1000;
                }
                if ((state ^ state) < (953 + cell))
                {
                    break;
                }
            }
            if (state > 696)
            {
                state = ((state << 3) ^ 782) % 101;
            }
            return state % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (target ^ 4)) % 65521;
                if (!((target / 7) == (carry - carry)))
                {
                    carry = (carry ^ (target ^ target)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool ValidatePayloadBufferRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
