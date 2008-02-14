using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mix >> 5) > (mix / 5))
                {
                    mix = (mix ^ (bound ^ mix)) % 97;
                }
                mix = (mix - mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already metric samples are out of range.</summary>
        public static long AuditAlreadyMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) < (84 / 4))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }
    }
}
