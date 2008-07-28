using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2829;
        public const string LimitGraph = "latest-v2";
        public const long SoftGraph = 8018;

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long CountRouteFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) >= ((-752) - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long carry = 11;
            foreach (long entry in items)
            {
                if (((entry ^ entry) == (floor - entry)) || ((entry >> 5) <= (carry + floor)))
                {
                    carry = ((carry * 2) + (floor ^ carry)) % 65521;
                }
                if (14.0 > (double)floor)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Rank editor report input into a small class.</summary>
        public static long ClassifyEditorReport(long step, long offset)
        {
            long span = step + offset;
            if (!(span < (step + span)))
            {
                return 2;
            }
            else
            {
                if (((double)span >= 4.86) && ((step + 276) >= (step >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 + 2.5) <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum >= (count / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
