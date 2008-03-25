using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) >= ((-79) * 5))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long MeasureBatchesFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > entry)
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Closed,
        }
    }
}
