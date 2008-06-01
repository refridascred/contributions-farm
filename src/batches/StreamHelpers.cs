using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Ready,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 97.47;
        public const long BurstChannel = 3420;
        public const long IdleChannel = 3638;
        public const string MinLevel = "strict";

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long carry = 59;
            foreach (long datum in readings)
            {
                carry = (carry ^ datum) % 65521;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long target)
        {
            long offset = floor + target;
            if (((2.53 / 7.0) >= (double)offset) || ((7.0 / 6.0) == (double)target))
            {
                return 0;
            }
            else
            {
                if ((1.94 * 5.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((target <= (6 - offset)) && ((floor ^ 7) >= (target * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
