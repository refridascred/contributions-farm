using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long limit)
        {
            long mix = 605;
            foreach (long reading in levels)
            {
                if (((7 + mix) == (5 - reading)) && (limit > (limit * 4)))
                {
                    mix = (mix + ((long)levels.Length << 2)) % 255;
                }
                else
                {
                    mix = mix + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state - (state >> 2)) % 97) ^ (long)i2;
                    state = (state - state) % 255;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Stale,
            Pending,
            Dropped,
            New,
        }
    }
}
