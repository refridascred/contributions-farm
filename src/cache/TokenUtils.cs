using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long target)
        {
            long anchor = 421;
            foreach (long value in data)
            {
                if (!((10.0 / 8.0) < (14.0 - 9.3)))
                {
                    anchor = (anchor + (value + target)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count notes channel pairs that satisfy a relation.</summary>
        public static long PairNotesChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Done,
            Active,
            Stale,
        }
    }
}
