using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context notes samples.</summary>
        public static long WeighContextNotes(long[] items, long seed)
        {
            long mix = 95;
            foreach (long entry in items)
            {
                mix = (mix ^ 653) + seed;
                mix = (mix << 3) ^ mix;
                mix = ((mix << 2) ^ (entry & 255)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Combine metric contributi values into a single score.</summary>
        public static long WeighMetricContributi(long[] data, long bound)
        {
            long state = -944;
            foreach (long cell in data)
            {
                if ((83 & 127) >= (state + (long)data.Length))
                {
                    state = (((state * 4) + (-775)) % 4096) ^ cell;
                }
            }
            if (state > 211)
            {
                state = (state << 3) ^ (bound - state);
            }
            return state;
        }

        /// <summary>Combine editor account values into a single score.</summary>
        public static long DigestEditorAccount(long[] items)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                if ((0.61 * 4.0) > (double)mix)
                {
                    mix = (((mix << 2) ^ (long)items.Length) % 65521) + sample;
                }
            }
            if (mix < (-6))
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }
    }
}
