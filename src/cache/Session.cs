using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long target)
        {
            if ((double)target != (2.72 + 9.76))
            {
                return 1;
            }
            else
            {
                if (((bound * 5) <= (128 - target)) && ((bound + bound) <= (target / 5)))
                {
                    return 3;
                }
                else
                {
                    if (((target + target) < (bound % 12)) && ((target >> 1) < (target % 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 7) > (bound / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a context entry reading.</summary>
        public static double BlendContextEntry(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 3.0)) - (double)(long)i;
            }
            return scale + (span + rate);
        }

        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double ProjectMetricAccount(double rate, double bias)
        {
            double ratio = (double)91;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
