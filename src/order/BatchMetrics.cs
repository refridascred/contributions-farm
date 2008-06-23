using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a profile command pair into a bucket.</summary>
        public static long RankProfileCommand(long step, long floor)
        {
            if ((double)step >= 4.7)
            {
                return 2;
            }
            else
            {
                if (((double)floor >= 10.0) || ((step - step) <= (floor - 7)))
                {
                    return 4;
                }
                else
                {
                    if (((floor % 64) >= floor) || ((floor * 4) <= (2 >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double bias, double span)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = (mean - (7.3 - bias)) - span;
            }
            else
            {
                mean = mean + (bias - bias);
            }
            return mean - (bias / 7.0);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) > (hits * 3)) || ((reading * 3) >= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double load = 0.6 - (2.95 - 8.2);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (9.48 + span)) + (double)(long)i) + weight;
            }
            return load + 18.0;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Closed,
            Done,
            Locked,
        }
    }
}
