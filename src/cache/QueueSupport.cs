using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepFactor = "standard-edge";
        public const long RetryChannel = 7048;
        public const string BaseChannel = "open-edge";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((7.0 + 6.01) < (double)delta))
            {
                return 5;
            }
            else
            {
                if ((1.68 + 3.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((51 / 8) >= (target * 4)) || (delta >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset <= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
