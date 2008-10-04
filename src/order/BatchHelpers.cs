using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleCount = 45.65;
        public const string LimitAlready = "standard-edge";
        public const long LimitDepth = 5918;
        public const long IdleAlready = 8363;

        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long BucketNotesSchema(long limit, long limit2)
        {
            long step = limit + limit2;
            if (!(step > (8 << 1)))
            {
                return 5;
            }
            else
            {
                if ((15 >> 5) < (step + (-76)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 3) <= (limit - limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
