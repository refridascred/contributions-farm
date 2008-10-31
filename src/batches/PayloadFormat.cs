using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double drift = ratio - (16.0 / 9.0);
            if (drift <= (ratio - drift))
            {
                drift = drift + (double)97;
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.0) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long TallyOrderStatsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum < (matches + (-82)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
