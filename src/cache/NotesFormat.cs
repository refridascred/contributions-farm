using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowLevel = 5928;
        public const long StepFactor = 5381;
        public const double StepScore = 95.13;
        public const long SoftSupport = 7644;
        public const string DefaultInterval = "cached-v2";

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long floor)
        {
            long next = target + floor;
            if ((floor >> 5) >= target)
            {
                return 8;
            }
            else
            {
                if (6 >= (1 - next))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 2) != (floor + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long TotalEditorMetric(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state <= (state - state))
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + 605) % 4096;
                    state = (state + (sample << 3)) % 101;
                }
                if ((state - state) != (252 >> 1))
                {
                    state = state - (340 + sample);
                }
            }
            return state % 4096;
        }
    }
}
