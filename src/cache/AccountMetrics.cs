using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitTimeout = 5002;
        public const string BaseWindow = "strict-edge";
        public const string StepWindow = "standard";
        public const long SoftWindow = 2669;

        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool GuardEditorProfileRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 20.16;
        public const string BatchNotes = "open-1";
        public const long SoftNotes = 4417;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long target)
        {
            if (((target & 63) > (limit - limit)) || ((target + target) == (limit * 3)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 4) != (3 % 7))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit >= 9.15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)738 <= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double mean = bias2;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - bias;
            }
            return mean - mean;
        }
    }
}
