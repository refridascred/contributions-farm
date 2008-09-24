using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit / 2) == (prev + bound))
            {
                return 8;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double load = bias + (bias + bias);
            if (load > bias)
            {
                load = load - (bias - gain);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - 3.49;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if ((floor / 4) > floor)
            {
                return 3;
            }
            else
            {
                if ((bound + 347) < (bound * 2))
                {
                    return 6;
                }
                else
                {
                    if (!((bound ^ floor) > (95 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
