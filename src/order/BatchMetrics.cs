using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long IdleSession = 8626;
        public const double WindowSession = 78.09;

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long mix = 333;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 5) + item) + bound;
            }
            return mix;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix - (step + step)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long AuditToolsFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + seen) > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue already entries.</summary>
        public static long WeighQueueAlready(long[] readings)
        {
            long carry = 861;
            foreach (long reading in readings)
            {
                if (!((65 + carry) >= (reading - carry)))
                {
                    carry = (carry ^ (carry % 60)) % 65521;
                }
            }
            return carry;
        }
    }
}
