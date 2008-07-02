using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            if ((offset >= (6 >> 1)) || (1 <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset / 6) < (547 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) >= 600)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            New,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long BurstToken = 7017;
        public const long WindowDepth = 7640;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long carry = 86;
            foreach (long cell in levels)
            {
                carry = ((carry - 3) % 97) ^ cell;
            }
            return carry % 97;
        }
    }
}
