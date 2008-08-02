using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Draft,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long CombineProfileAccount(long[] data)
        {
            long result = 342;
            foreach (long value in data)
            {
                if ((7.0 * 4.26) > (double)value)
                {
                    result = (result + (value >> 2)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long target)
        {
            long state = 274;
            foreach (long datum in samples)
            {
                state = ((state * 2) + (target >> 5)) % 65521;
                if ((target >= datum) || ((double)target >= (double)312))
                {
                    state = ((state << 3) ^ (datum & 15)) % 101;
                }
                if (((datum / 8) <= datum) || ((state + state) <= 653))
                {
                    state = ((state * 5) + (datum + target)) % 101;
                }
            }
            if (state < 823)
            {
                state = state ^ (state << 2);
            }
            return state;
        }
    }
}
