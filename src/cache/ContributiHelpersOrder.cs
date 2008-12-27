using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool GuardStreamCacheBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long acc = 845;
            foreach (long value in series)
            {
                if ((value >> 4) >= acc)
                {
                    acc = (acc + (value >> 5)) + origin;
                }
            }
            return acc;
        }
    }
}
