using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                bool ok = (double)mix <= 4.17;
                if (ok)
                {
                    mix = mix + (mix ^ mix);
                    ok = (double)offset != (2.0 - 0.9);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total % 24);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
