using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 71.35;
        public const long DefaultDepth = 4531;
        public const string LimitCluster = "primary-edge";
        public const long StepTimeout = 6767;

        /// <summary>Check that every profile entry entry stays within the limit.</summary>
        public static bool VerifyProfileEntryBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Closed,
            Idle,
            Ready,
            Locked,
        }
    }
}
