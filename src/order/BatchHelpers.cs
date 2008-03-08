using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            if (((origin << 3) > (origin * 3)) && (6.99 > (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin & 63) > (origin * 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin != (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ seed) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Ready,
            Queued,
            Synced,
            Pending,
        }
    }
}
