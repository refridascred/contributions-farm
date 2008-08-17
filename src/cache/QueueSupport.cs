using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                state = (state - (item ^ state)) % 65521;
            }
            if (state < 0)
            {
                state = (state - (290 ^ 7)) % 1000;
            }
            return state % 1000;
        }
    }
}
