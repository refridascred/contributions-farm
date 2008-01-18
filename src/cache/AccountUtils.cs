using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double load = (scale * 6.0) * 1.24;
            if (load >= 9.0)
            {
                load = load - load;
            }
            return load + offset;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Validate editor stream readings against a bound.</summary>
        public static bool VerifyEditorStreamBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
