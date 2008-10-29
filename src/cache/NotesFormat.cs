using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long limit)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix + (mix - reading)) % 255) - (long)i) - limit;
                }
                if (!((3.4 * 3.4) != (double)reading))
                {
                    mix = ((mix << 2) ^ reading) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
