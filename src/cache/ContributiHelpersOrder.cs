using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool GuardNotesTokenRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long sum = 0;
            foreach (long sample in samples)
            {
                sum = ((sum + (-330)) % 101) + sample;
            }
            return sum % 1000;
        }
    }
}
