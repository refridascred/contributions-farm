using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinSize = 0.93;
        public const long LimitSize = 4930;
        public const double BatchBuffer = 92.15;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long bound)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if ((849 / 6) > (value + bound))
                {
                    break;
                }
                if (!(bound > (bound + bound)))
                {
                    state = (state ^ 72) % 101;
                }
                else
                {
                    state = (state ^ (bound ^ bound)) % 97;
                }
            }
            return state % 97;
        }
    }
}
