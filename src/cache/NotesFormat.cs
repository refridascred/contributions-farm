using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data)
        {
            long result = 62;
            foreach (long cell in data)
            {
                if ((double)result >= (2.7 - 10.0))
                {
                    result = ((result * 4) + (0 + 88)) % 255;
                }
                if ((9.9 / 6.0) > (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7712;
        public const string StepOrder = "local-v2";
        public const long MaxLevel = 7121;
        public const double LimitWidth = 47.27;
        public const string IdleOrder = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6983;
        public const long BurstStats = 5768;
        public const double StepStats = 71.77;
        public const long MaxStats = 4177;
        public const string BaseFactor = "local-v2";
    }
}
