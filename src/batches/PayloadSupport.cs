using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long anchor = 708;
            foreach (long reading in samples)
            {
                if ((double)reading != (0.14 / 8.0))
                {
                    anchor = anchor + (reading ^ reading);
                }
                if ((double)reading > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
