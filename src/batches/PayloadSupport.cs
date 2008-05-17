using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long CountBatchesChecksGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((offset >> 1) == (offset - offset))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long RollFilterGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
