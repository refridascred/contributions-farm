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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long acc = 13;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + (limit >> 1)) % 255) - reading;
            }
            return acc;
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
