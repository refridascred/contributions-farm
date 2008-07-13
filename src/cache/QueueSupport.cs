using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long mix = 24;
            foreach (long sample in items)
            {
                if (((sample - target) >= ((long)items.Length - sample)) && ((77 >> 4) > (sample + 5)))
                {
                    mix = (mix - 22) % 97;
                }
                mix = ((mix << 2) ^ (57 / 9)) % 65521;
                if ((double)sample < (6.1 * 2.2))
                {
                    mix = (mix + 647) % 97;
                }
            }
            if (mix > (-70))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) != (seen / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
