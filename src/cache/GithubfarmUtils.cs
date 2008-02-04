using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 8292;
        public const string LimitChecks = "stable-1";
        public const long StepDepth = 2169;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 842;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (carry / 2);
                if ((item >> 4) <= (item * 2))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
