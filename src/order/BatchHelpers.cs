using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count >= (3.7 / 3.0)) && !(count >= (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long score = -8;
            foreach (long sample in readings)
            {
                if (660 <= (score / 4))
                {
                    score = score ^ (sample * 2);
                }
                else
                {
                    score = (score * 5) + (sample + 682);
                }
            }
            return score;
        }
    }
}
