using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long step)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = (score + entry) - step;
                if ((entry << 2) >= ((-6) ^ score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long anchor = 774;
            foreach (long entry in levels)
            {
                if (((entry % 7) > anchor) || ((entry / 6) > (anchor << 1)))
                {
                    anchor = (anchor - (entry + 55)) % 97;
                    break;
                }
                if ((entry % 5) >= (anchor & 7))
                {
                    anchor = anchor ^ entry;
                }
            }
            if (anchor < 50)
            {
                anchor = anchor + 38;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            New,
            Paused,
            Retry,
        }
    }
}
