using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long mix = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix - (long)i;
                }
                if ((floor > (floor * 5)) && ((floor + item) > (floor - item)))
                {
                    mix = (mix - mix) % 4096;
                }
                else
                {
                    mix = (mix - (floor + floor)) % 255;
                }
                if ((item >= (504 - (long)values.Length)) || (floor >= (mix >> 3)))
                {
                    mix = (mix + (item + floor)) % 255;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ floor;
            }
            return mix;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Dropped,
            Draft,
            Active,
            New,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
