using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(809 < datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long seed)
        {
            if (!((double)seed != (1.6 + 9.61)))
            {
                return 0;
            }
            else
            {
                if ((double)seed <= (1.48 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed + limit) < 881)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit == (9.0 * 2.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Pending,
            Paused,
        }
    }
}
