using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 3;
            foreach (long value in items)
            {
                if ((double)value >= (0.4 / 3.0))
                {
                    break;
                }
                if ((2.0 * 2.93) < (double)value)
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry - (value / 9);
                }
                if (1.9 > (8.64 / 9.0))
                {
                    break;
                }
            }
            if (carry < 769)
            {
                carry = (carry ^ (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long SortRecordQueue(long target, long seed)
        {
            if ((9.62 - 5.0) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed / 6))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 642;
        public const long MinFormat = 5597;
        public const double BatchLevel = 25.06;
        public const long CacheTimeout = 6735;

        /// <summary>Measure how many cache context samples are out of range.</summary>
        public static long CountCacheContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) <= entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
