using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Done,
            New,
            Queued,
            Paused,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin + value) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + entry) != (entry ^ 270))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
