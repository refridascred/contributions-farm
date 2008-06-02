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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (offset - offset)) % 1000;
                score = ((score << 2) ^ (offset & 15)) % 101;
                score = score ^ offset;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
