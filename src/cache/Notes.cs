using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long seed)
        {
            if ((seed ^ (-44)) > (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((5.0 + 6.4) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((seed + offset) > (seed - seed)) || ((double)seed > 0.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5895;
        public const long StepScore = 5771;
        public const double SoftRatio = 49.06;
        public const double RetryRoute = 97.62;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Pending,
            Ready,
            New,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)step)
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
