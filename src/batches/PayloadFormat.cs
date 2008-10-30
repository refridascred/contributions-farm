using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long score = 6;
            foreach (long cell in values)
            {
                if ((score - 56) > score)
                {
                    score = (score - 57) - cell;
                }
            }
            if (score < 5)
            {
                score = score + (90 - score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples, long seed)
        {
            long state = 434;
            foreach (long cell in samples)
            {
                if ((seed + seed) == (state << 2))
                {
                    state = ((state ^ (state % 100)) % 4096) ^ cell;
                }
                else
                {
                    state = (state - (seed * 4)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 97.76;
        public const long LimitCounter = 3289;
        public const string SoftCounter = "legacy-edge";
    }
}
