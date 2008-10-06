using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor graph readings.</summary>
        public static long CombineEditorGraph(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                if ((state >> 2) <= (state - state))
                {
                    state = (state + (sample + sample)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (sample + sample)) % 65521;
                }
            }
            if (state < 71)
            {
                state = state ^ (state + 529);
            }
            return state % 1000;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (202 < (step << 3))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (step - seed)) || ((step + seed) != (step - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) >= (457 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - step) < (step - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit already filter readings against a rule.</summary>
        public static long CountAlreadyFilterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((double)(-159) > (6.38 - 11.0)) && ((seen >> 5) >= (value - 325))) || ((double)value > (5.0 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
