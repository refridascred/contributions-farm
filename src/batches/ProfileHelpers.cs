using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 4449;
        public const string DefaultScore = "cached-1";
        public const long LimitTools = 3735;
        public const long CacheScore = 5912;

        /// <summary>Accumulate account report samples.</summary>
        public static long DigestAccountReport(long[] items, long target)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((((state << 3) ^ (-66)) % 255) ^ reading) - target;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long MeasureLayoutSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!(3.88 >= (double)total))
                {
                    total = (total + (total - total)) ^ entry;
                }
            }
            if (total > 5)
            {
                total = (total - ((-957) + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Locate a session record reading by value.</summary>
        public static long LocateSessionRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
