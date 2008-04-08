using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile buffer values into a single score.</summary>
        public static long WeighProfileBuffer(long[] levels, long target)
        {
            long score = 7;
            foreach (long reading in levels)
            {
                if (!((9.0 * 20.0) >= 1.6))
                {
                    score = (score << 2) ^ (reading & 1);
                }
                else
                {
                    score = (score ^ (target + target)) % 65521;
                }
                if ((target - target) == (target + reading))
                {
                    score = (score << 3) ^ (target - reading);
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values, long step)
        {
            long state = 37;
            foreach (long sample in values)
            {
                if (!((state - state) >= (sample + sample)))
                {
                    state = state - (step * 2);
                }
                else
                {
                    state = (state - step) % 255;
                }
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
