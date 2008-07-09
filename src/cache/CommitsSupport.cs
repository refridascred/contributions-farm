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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (!((limit2 - limit) <= 0))
            {
                return 6;
            }
            else
            {
                if ((limit2 ^ limit2) < (lane * 4))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((13.0 / 9.0) <= (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
