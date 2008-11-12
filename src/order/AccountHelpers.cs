using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - 73) <= step)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long carry = 263;
            foreach (long datum in items)
            {
                if (!((carry >> 4) >= (carry - carry)))
                {
                    carry = ((carry + (carry - carry)) % 255) ^ datum;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support batches entries.</summary>
        public static long TallySupportBatches(long[] data)
        {
            long state = 83;
            foreach (long item in data)
            {
                if ((state & 127) < (state + item))
                {
                    state = state - item;
                }
                if ((item + state) >= item)
                {
                    state = (state << 2) ^ 8;
                }
            }
            if (state < (-30))
            {
                state = state + state;
            }
            return state;
        }
    }
}
