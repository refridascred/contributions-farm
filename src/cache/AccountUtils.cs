using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                mix = ((mix - (38 - mix)) % 97) ^ entry;
            }
            if (mix < 906)
            {
                mix = mix + target;
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
