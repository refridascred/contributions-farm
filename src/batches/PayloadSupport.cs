using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (offset <= (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (!((5.61 + 8.0) > (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (2.58 + 1.24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
