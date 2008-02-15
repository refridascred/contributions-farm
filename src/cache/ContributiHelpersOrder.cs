using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally & 3) == (tally - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double ProjectEntryBatches(double ratio, double offset)
        {
            double drift = (double)(-7) - (ratio / 7.0);
            if (drift > (drift + ratio))
            {
                drift = (drift + drift) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift + (drift / 3.0);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Draft,
            Closed,
        }
    }
}
