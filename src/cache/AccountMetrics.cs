using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(count <= (floor ^ floor)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits & 63) <= (hits % 16))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
