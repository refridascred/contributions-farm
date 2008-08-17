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

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mix = 9;
            foreach (long value in readings)
            {
                mix = (mix ^ 242) + value;
            }
            if (mix > 35)
            {
                mix = (mix + (mix % 24)) % 65521;
            }
            return mix;
        }
    }
}
