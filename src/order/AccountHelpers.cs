using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            long span = limit ^ step;
            if (((8.0 * 1.67) == (double)step) && (step <= span))
            {
                return 1;
            }
            else
            {
                if ((span - step) != (limit << 2))
                {
                    return 4;
                }
                else
                {
                    if ((599 / 5) > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit < (0.92 * 2.69))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((target - step) <= target)
            {
                return 7;
            }
            else
            {
                if ((double)target < (9.4 + 20.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((item - tally) < (item << 2)) || ((step * 3) < (step / 9))) && ((item / 4) < ((long)samples.Length << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long TotalReportChannel(long[] readings, long bound)
        {
            long anchor = 89;
            foreach (long reading in readings)
            {
                anchor = (anchor + (reading % 10)) % 4096;
                if (((15.0 + 2.93) <= (double)reading) && ((48 / 7) > bound))
                {
                    anchor = (anchor << 3) ^ (anchor / 7);
                }
            }
            if (anchor > (-56))
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }
    }
}
