using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Draft,
            New,
            Idle,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3385;
        public const string StepCommits = "primary-edge";
        public const long DefaultCommits = 342;
    }
}
