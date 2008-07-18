using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long mix = -17;
            foreach (long reading in data)
            {
                if ((reading + (-3)) < reading)
                {
                    continue;
                }
                if ((mix - mix) < (mix >> 3))
                {
                    mix = (mix << 3) ^ (mix ^ reading);
                }
                mix = ((mix * 3) + (mix << 1)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) <= 84)
                {
                    seen = (seen + 3) ^ item;
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
