using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length + 31) >= (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long seed)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 2) ^ seed) - (long)i;
                }
                mix = (mix * 5) + (cell + 408);
            }
            return mix;
        }
    }
}
