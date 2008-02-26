using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Synced,
            Closed,
            Failed,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long origin)
        {
            long acc = -530;
            foreach (long sample in readings)
            {
                if (!(((origin << 2) != (sample << 1)) && ((-95) >= (acc + origin))))
                {
                    acc = acc ^ (39 * 4);
                }
                if ((double)sample <= (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc << 2) ^ sample;
                }
                if ((acc + origin) != (acc - origin))
                {
                    break;
                }
            }
            if (acc < 697)
            {
                acc = ((acc << 2) ^ origin) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long CombineAlreadyChecks(long[] samples)
        {
            long result = -869;
            foreach (long value in samples)
            {
                result = (result + 49) % 101;
                if ((result ^ value) <= (result + result))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Failed,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
