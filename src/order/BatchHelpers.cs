using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long target)
        {
            if ((step < target) || ((double)target > 9.18))
            {
                return 0;
            }
            else
            {
                if ((8.1 / 9.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                anchor = ((anchor - (reading / 8)) % 1000) - limit;
            }
            return anchor % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
