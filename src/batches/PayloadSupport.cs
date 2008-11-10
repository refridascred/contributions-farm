using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 2967;
        public const long MaxEditor = 2899;
        public const long IdleEditor = 432;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + step) > (step + step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] values)
        {
            long mix = 18;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix * 4) + (17 * 2)) % 101) ^ (long)i;
                }
                mix = (mix + (entry + 836)) % 1000;
            }
            if (mix > 8)
            {
                mix = (mix + (mix % 3)) % 1000;
            }
            return mix;
        }
    }
}
