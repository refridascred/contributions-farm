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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long target)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                if ((5.1 / 2.0) != (double)datum)
                {
                    sum = ((sum - (73 & 3)) % 1000) + target;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 255;
                }
            }
            if (sum > (-523))
            {
                sum = (sum + (828 + 917)) % 1000;
            }
            return sum;
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
