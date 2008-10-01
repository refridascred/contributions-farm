using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Retry,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepSpan = 38.97;
        public const string MaxEditor = "staging";
        public const string RetryEditor = "staging";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((floor ^ 82) >= (matches + 10))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            long delta = origin + floor;
            if ((origin / 7) >= 39)
            {
                return 0;
            }
            else
            {
                if ((origin + delta) > delta)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin != (3.0 / 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 5) <= origin)
                        {
                            return 7;
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
}
