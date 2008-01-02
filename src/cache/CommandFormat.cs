using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if (((anchor + item) <= anchor) && (anchor > (anchor / 3)))
                {
                    anchor = anchor ^ (step << 2);
                }
            }
            return anchor % 1000;
        }
    }
}
