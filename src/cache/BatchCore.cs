using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((entry + 670) > (step * 4)) && ((step + seen) == (entry - step))) && (((15.0 * 5.1) >= (double)entry) && ((double)93 == (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings)
        {
            long mark = 90;
            foreach (long reading in readings)
            {
                mark = (mark * 2) + (reading - reading);
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            Closed,
            Synced,
        }
    }
}
