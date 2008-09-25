using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long score = 593;
            foreach (long reading in values)
            {
                if ((score + score) < (reading * 4))
                {
                    score = score - (score / 3);
                }
                if ((334 - reading) != (score * 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((tally / 9) <= (8 >> 5)) && (((-37) / 8) > (entry >> 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
