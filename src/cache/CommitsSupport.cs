using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile queue entry stays within the limit.</summary>
        public static bool VerifyProfileQueueRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values, long limit)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ limit) + reading;
            }
            return carry;
        }

        /// <summary>Compare every pair of checks already readings.</summary>
        public static long PairChecksAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
