using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long bound)
        {
            long span = step + bound;
            if ((bound & 63) == (bound >> 1))
            {
                return 3;
            }
            else
            {
                if (((bound ^ 24) > step) || ((bound / 5) < (span * 4)))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - bound))
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

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long TallyCommitsCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
