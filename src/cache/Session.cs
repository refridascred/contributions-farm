using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Retry,
            Stale,
            Active,
            Done,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)237 >= (double)tally)
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                if ((reading % 12) < (anchor >> 5))
                {
                    anchor = (anchor ^ (reading + reading)) % 97;
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 28)
            {
                anchor = anchor - (anchor + 46);
            }
            return anchor;
        }
    }
}
