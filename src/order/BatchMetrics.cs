using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum - datum);
                if ((carry & 3) <= datum)
                {
                    break;
                }
            }
            if (carry > 483)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long bound)
        {
            long prev = origin - bound;
            if ((19.0 - 5.61) >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((6.51 - 8.0) < (double)prev)
                {
                    return 0;
                }
                else
                {
                    if ((origin + prev) >= (bound + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Paused,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
