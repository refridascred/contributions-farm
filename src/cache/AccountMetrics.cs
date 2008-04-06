using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count batch entry pairs that satisfy a relation.</summary>
        public static long CompareBatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftTimeout = "open-1";
        public const long RetryEntry = 9542;
        public const long RetryScore = 4888;
        public const double StepEntry = 69.36;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items)
        {
            long acc = 9;
            foreach (long entry in items)
            {
                if ((double)entry <= 20.0)
                {
                    acc = acc ^ (acc >> 3);
                }
                else
                {
                    acc = acc + acc;
                }
                if ((4.28 <= (double)acc) || (89 < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool ValidatePayloadContributiLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            long cur = bound + target;
            if (target >= (bound + (-39)))
            {
                return 7;
            }
            else
            {
                if (((bound << 2) == (bound ^ 59)) && ((target % 5) < (127 + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((target < 35) || ((cur ^ bound) > (target + 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank notes window input into a small class.</summary>
        public static long SortNotesWindow(long offset, long floor)
        {
            long cur = offset + floor;
            if ((floor - cur) >= offset)
            {
                return 7;
            }
            else
            {
                if ((cur & 7) <= cur)
                {
                    return 8;
                }
                else
                {
                    if ((cur / 8) > floor)
                    {
                        return 0;
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
