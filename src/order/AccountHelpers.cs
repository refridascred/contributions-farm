using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((origin * 5) < (origin * 4)) && ((origin - state) != (value - 9)))
                {
                    state = (state * 5) + ((-1) - state);
                }
            }
            if (state > 711)
            {
                state = ((state << 3) ^ (state + origin)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate cluster batch samples.</summary>
        public static long WeighClusterBatch(long[] series)
        {
            long anchor = 96;
            foreach (long sample in series)
            {
                if ((sample ^ anchor) <= anchor)
                {
                    anchor = ((anchor * 2) + (sample ^ sample)) % 65521;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of window account readings.</summary>
        public static long CompareWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
