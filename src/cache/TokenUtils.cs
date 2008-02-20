using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                if (!((mix + mix) <= (cell >> 3)))
                {
                    mix = mix - (mix % 7);
                }
                if (((mix >> 1) == (cell + 26)) && ((double)mix <= 12.0))
                {
                    mix = ((mix << 2) ^ (cell + mix)) % 97;
                }
                else
                {
                    mix = (mix + 885) % 1000;
                }
                if ((cell + cell) < (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
