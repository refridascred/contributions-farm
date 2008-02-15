using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = -89;
            foreach (long sample in items)
            {
                if ((acc >= (sample * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (sample / 8)) % 101;
                    acc = acc - ((-44) + acc);
                }
                if (((4.55 * 1.3) == (double)sample) && ((1.0 + 4.38) != (double)sample))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate batch graph readings against a bound.</summary>
        public static bool ValidateBatchGraphRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
