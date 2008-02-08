using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Dropped,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long floor, long target)
        {
            if (((double)floor >= (16.0 + 10.0)) && ((floor & 255) < floor))
            {
                return 2;
            }
            else
            {
                if ((double)target > (5.5 + 14.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
