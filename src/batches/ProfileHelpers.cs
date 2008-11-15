using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Stale,
            Failed,
            Retry,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= 14.0)
            {
                weight = (weight + (double)(-37)) + offset;
            }
            else
            {
                weight = weight + (ratio * 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long ClassifySupportMetric(long origin, long step)
        {
            if (step >= 5)
            {
                return 4;
            }
            else
            {
                if ((step * 2) > (origin - step))
                {
                    return 7;
                }
                else
                {
                    if (((double)step >= 5.92) || ((4.0 - 4.8) == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 8) > step) || (origin > (step & 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool VerifyMetricReportBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
