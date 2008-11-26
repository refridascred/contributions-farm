using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 3) != (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (double)9) || (count < (count >> 5)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
