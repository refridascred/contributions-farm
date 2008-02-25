using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Paused,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long CombineSchemaRoute(long[] readings)
        {
            long acc = 669;
            foreach (long datum in readings)
            {
                acc = ((acc * 3) + (datum / 8)) % 65521;
            }
            if (acc > (-8))
            {
                acc = (acc ^ ((long)readings.Length - acc)) % 4096;
            }
            return acc;
        }
    }
}
