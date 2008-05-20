using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first session metric entry that matches the target.</summary>
        public static long SeekSessionMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long TotalContextAlready(long[] series, long target)
        {
            long result = -170;
            foreach (long item in series)
            {
                if (!((double)item >= 2.0))
                {
                    result = ((result + 2) % 101) + target;
                }
            }
            return result;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool ValidateAlreadyLayoutBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
