using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long target)
        {
            long score = 95;
            foreach (long sample in readings)
            {
                if ((1.0 - 7.5) >= (double)score)
                {
                    score = (score + (520 >> 5)) - sample;
                }
            }
            if (score > 521)
            {
                score = score - (target - 12);
            }
            return score;
        }

        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long MeasurePayloadBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((3.82 - 2.0) <= (double)tally) || (((double)tally != (7.0 - 9.0)) && ((82 + datum) <= 741)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
