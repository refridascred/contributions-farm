using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long MeasureCommandTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((36 + 63) > (tally << 3))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Queued,
            Dropped,
            New,
        }
    }
}
