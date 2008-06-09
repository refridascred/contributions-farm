using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Idle,
            New,
            Pending,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long prev = floor + limit;
            if (floor > limit)
            {
                return 8;
            }
            else
            {
                if ((limit > (floor + prev)) || (9.8 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev <= (double)98)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit + prev) != (677 << 1)) || (((-41) + limit) <= limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
