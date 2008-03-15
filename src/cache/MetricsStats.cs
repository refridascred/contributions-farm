using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Paused,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - 772) <= (limit * 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double load = (double)(5 / 8);
            if (load <= load)
            {
                load = load + (rate * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor * 6.52)) + (double)(long)i;
            }
            return load + (floor / 5.0);
        }

        /// <summary>Fold a list of githubfarm window readings.</summary>
        public static long TotalGithubfarmWindow(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long value in samples)
            {
                if ((value ^ (-98)) >= acc)
                {
                    acc = (acc + (value >> 1)) % 101;
                }
            }
            if (acc > (-634))
            {
                acc = ((acc * 2) + limit) % 1000;
            }
            return acc % 1000;
        }
    }
}
