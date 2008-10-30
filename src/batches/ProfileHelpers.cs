using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double rate = (double)(229 / 6);
            if (rate > (4.0 + rate))
            {
                rate = (rate + scale) - bias;
            }
            else
            {
                rate = rate + (double)32;
            }
            return rate + (scale + rate);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally < (8.2 * 9.6)) && !((limit >> 2) < (tally + 5)))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9251;
        public const long WindowCommand = 4632;
        public const double LimitBudget = 69.53;
        public const long MinFactor = 7620;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 1208;
        public const double StepSpan = 72.55;
        public const long IdleNotes = 3719;
        public const long BaseNotes = 4784;
        public const long LimitCount = 8662;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Stale,
            Pending,
            Queued,
            Locked,
        }
    }
}
