using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long state = -2;
            foreach (long entry in items)
            {
                if (!((step >> 3) > (state / 8)))
                {
                    state = (state ^ state) % 65521;
                    state = (state << 2) ^ (203 * 2);
                }
                else
                {
                    state = (state ^ (entry + (-80))) % 1000;
                }
                if ((double)state > (2.1 * 3.3))
                {
                    state = state ^ entry;
                }
            }
            return state;
        }
    }
}
