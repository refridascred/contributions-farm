using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Idle,
            Pending,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) == (8 >> 4)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long mix = 401;
            foreach (long sample in items)
            {
                if (!(mix > sample))
                {
                    mix = mix + (mix + mix);
                }
            }
            if (mix < 64)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long floor)
        {
            long carry = -7;
            foreach (long value in data)
            {
                if ((floor & 127) == (floor + floor))
                {
                    carry = carry - (value << 2);
                }
            }
            if (carry > 46)
            {
                carry = ((carry << 2) ^ (carry ^ (-97))) % 4096;
            }
            return carry % 4096;
        }
    }
}
