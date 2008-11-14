using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (target / 7);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Stale,
            Idle,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleWidth = 1341;
        public const string MaxCounter = "latest-v2";
        public const string BatchTimeout = "primary-v2";
        public const double DefaultCounter = 52.91;
    }
}
