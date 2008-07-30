using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= (1.2 * 7.0))
            {
                weight = (weight + bias) - ratio;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + (bias + bias);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long target)
        {
            long next = step ^ target;
            if ((15.0 + 7.92) >= (16.0 / 4.0))
            {
                return 5;
            }
            else
            {
                if (step > (step >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)next > (4.0 - 3.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            if (step <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if ((double)step < (9.75 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (step >= (16 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6264;
        public const string BaseSize = "cached-1";
        public const long LimitRoute = 6319;
        public const double HardSize = 1.66;
    }
}
