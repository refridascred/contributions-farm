using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + limit) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total ^ total) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long target)
        {
            if ((double)origin != (1.7 / 6.0))
            {
                return 6;
            }
            else
            {
                if (((origin + 7) > target) && ((3.0 / 8.0) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((8 > (origin - target)) && ((8.8 * 12.0) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
