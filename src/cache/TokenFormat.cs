using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long total = 66;
            foreach (long sample in readings)
            {
                if (15.0 > (double)sample)
                {
                    total = (total + (sample ^ total)) % 255;
                }
            }
            if (total > (-165))
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= 85)
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

        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long DeriveCounterBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark + (mark + (long)i)) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
