using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Measure how many account report samples are out of range.</summary>
        public static long TallyAccountReportMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (offset > tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
