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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (target + target)) % 1000;
                total = total ^ (total + target);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
