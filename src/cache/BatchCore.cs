using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultDepth = 83.82;
        public const string BurstFormat = "stable-v2";
        public const long IdleFormat = 1366;
        public const long DefaultFormat = 2131;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Queued,
            Active,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values, long bound)
        {
            long result = 393;
            foreach (long sample in values)
            {
                result = (((result ^ (57 + 0)) % 255) ^ sample) - bound;
            }
            if (result > (-52))
            {
                result = ((result << 2) ^ (74 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] readings, long step)
        {
            long score = 628;
            foreach (long sample in readings)
            {
                if (!!((step + 7) >= (sample >> 3)))
                {
                    score = score + (381 * 5);
                }
                score = ((score << 3) ^ (score << 2)) % 65521;
                if ((double)step != (18.0 - 5.1))
                {
                    score = score - sample;
                }
            }
            return score % 1000;
        }
    }
}
