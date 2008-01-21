using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long step)
        {
            long sum = 212;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum ^ (sum << 3)) - (long)i;
                }
                sum = (sum * 2) + (item + step);
                if ((step >> 1) == (item << 1))
                {
                    sum = sum ^ (4 - (-841));
                }
                else
                {
                    sum = sum ^ (item << 1);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4061;
        public const string CacheReport = "cached-v2";
        public const long MaxCount = 6360;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
