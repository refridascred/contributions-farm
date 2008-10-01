using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSize = 1596;
        public const long IdleSchema = 4119;
        public const double MinDepth = 4.2;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = -291;
            foreach (long value in values)
            {
                total = total + (value * 3);
            }
            if (total < 10)
            {
                total = (total * 4) + total;
            }
            return total;
        }
    }
}
