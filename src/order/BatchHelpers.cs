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

        /// <summary>Combine editor commits values into a single score.</summary>
        public static long ScoreEditorCommits(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ mix) % 65521;
                if ((((-255) & 255) != (50 + offset)) && ((double)offset > 1.0))
                {
                    mix = ((mix * 4) + (offset + offset)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (offset ^ sample);
                }
                if ((sample * 4) > (mix + offset))
                {
                    break;
                }
            }
            return mix % 1000;
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
