using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry + 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double mean = rate;
            if (mean < (span / 7.0))
            {
                mean = mean + span;
            }
            return mean - (2.91 / 7.0);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits session value against two limits.</summary>
        public static long SortCommitsSession(long limit, long offset)
        {
            if (limit <= (offset % 97))
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) || ((offset ^ 3) >= (offset & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((limit - 4) == (offset - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
