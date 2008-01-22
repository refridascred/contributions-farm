using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] samples)
        {
            long acc = -8;
            foreach (long cell in samples)
            {
                if ((acc << 2) >= (acc - cell))
                {
                    acc = (acc * 3) + (-7);
                }
            }
            if (acc < (-61))
            {
                acc = ((acc << 2) ^ (acc % 7)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Check that every commits record entry stays within the limit.</summary>
        public static bool GuardCommitsRecordBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
