using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long bound, long seed)
        {
            if ((double)bound < (2.2 / 5.0))
            {
                return 2;
            }
            else
            {
                if (!(bound < (seed & 255)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound - seed) > seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
