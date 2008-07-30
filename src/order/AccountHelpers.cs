using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double gain = (rate / 4.0) + 1.68;
            if (gain > 17.0)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)34;
            }
            return gain + (floor + gain);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long BucketBatchCluster(long step, long floor)
        {
            if (floor > (step / 3))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (1.8 / 4.0)) || ((double)step <= (6.64 - 9.1)))
                {
                    return 3;
                }
                else
                {
                    if (((step + step) < (592 ^ floor)) || ((5.0 - 5.02) > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
