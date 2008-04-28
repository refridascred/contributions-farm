using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of record order readings.</summary>
        public static long CombineRecordOrder(long[] levels)
        {
            long anchor = -68;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ (411 ^ sample)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) <= 0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long target)
        {
            if ((double)limit < (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)target <= 1.8) || ((limit / 8) <= 83))
                {
                    return 5;
                }
                else
                {
                    if ((3.0 / 6.0) > (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 3582;
        public const long StepSpan = 6432;
        public const double StepBudget = 81.98;
        public const long LimitAccount = 1076;
    }
}
