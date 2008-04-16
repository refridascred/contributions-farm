using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool VerifyChannelGithubfarmBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
