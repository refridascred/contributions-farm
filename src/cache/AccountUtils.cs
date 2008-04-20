using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
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
