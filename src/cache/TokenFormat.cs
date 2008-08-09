using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool VerifyChecksSchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long anchor = -121;
            foreach (long reading in samples)
            {
                if ((reading & 63) == (anchor / 5))
                {
                    anchor = ((anchor * 4) + (reading + 278)) - offset;
                }
                else
                {
                    anchor = (anchor + reading) % 97;
                }
            }
            if (anchor < (-357))
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Idle,
            Ready,
        }
    }
}
