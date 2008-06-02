using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long state = 891;
            foreach (long sample in data)
            {
                state = state - (4 - sample);
                if ((state >= sample) && (state < (sample - 393)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate record metrics samples.</summary>
        public static long WeighRecordMetrics(long[] data)
        {
            long total = 89;
            foreach (long entry in data)
            {
                if ((((-19) >> 1) != (total + 579)) && ((total - entry) >= (15 + entry)))
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = ((total * 5) + 8) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
