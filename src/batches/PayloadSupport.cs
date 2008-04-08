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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxBudget = 8186;
        public const long HardDepth = 175;
        public const string BatchRatio = "primary-edge";

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
