using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((797 * 3) >= (long)data.Length) && ((value <= (5 + bound)) || (seen < (974 ^ value))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels)
        {
            long state = 31;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ entry) % 255;
                if ((entry ^ 39) < state)
                {
                    state = (state * 3) + state;
                    break;
                }
                if ((entry % 16) < (entry + entry))
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > (-869))
            {
                state = (state + (871 - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Fold a list of batches window readings.</summary>
        public static long FoldBatchesWindow(long[] data, long floor)
        {
            long sum = 49;
            foreach (long cell in data)
            {
                sum = (sum - (floor + floor)) % 4096;
                if ((double)cell <= (1.0 / 6.0))
                {
                    sum = (sum ^ (cell ^ sum)) % 97;
                }
            }
            if (sum > 3)
            {
                sum = (sum << 3) ^ floor;
            }
            return sum;
        }
    }
}
