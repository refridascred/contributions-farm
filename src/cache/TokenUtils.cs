using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if (limit >= (-344))
            {
                return 5;
            }
            else
            {
                if (!(((-31) - 8) < (limit * 4)))
                {
                    return 0;
                }
                else
                {
                    if (((986 + limit) < (limit - bound)) && ((9 - bound) >= bound))
                    {
                        return 3;
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
