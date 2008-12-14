using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Done,
            Dropped,
        }

        /// <summary>Classify a profile buffer pair into a bucket.</summary>
        public static long GradeProfileBuffer(long step, long offset)
        {
            long delta = step ^ offset;
            if ((step ^ delta) >= (delta % 60))
            {
                return 7;
            }
            else
            {
                if ((step * 3) < (delta + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.3 * 3.77))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + 94) <= (delta >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "fallback";
        public const long LimitPayload = 1332;
        public const long BurstPayload = 4907;
        public const long MinBudget = 8838;
        public const double StepPayload = 96.75;

        /// <summary>Count the contributi order entries that pass the check.</summary>
        public static long MeasureContributiOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) >= 9)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
