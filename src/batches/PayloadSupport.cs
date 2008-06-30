using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream record samples are out of range.</summary>
        public static long TallyStreamRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (52 >= (23 - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item != (5.91 - 4.2)) || (matches < (matches % 97)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
