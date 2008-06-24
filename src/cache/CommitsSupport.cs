using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleCount = 8022;
        public const string IdleEntry = "latest-v2";
        public const long StepEntry = 9917;

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double bias = 7.9;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + weight;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long step)
        {
            if (((12.0 * 0.17) > (double)step) && (8.84 > (double)target))
            {
                return 3;
            }
            else
            {
                if ((10.0 * 18.0) < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Pending,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Scale a command tools figure with a bias.</summary>
        public static double ScaleCommandTools(double bias, double floor)
        {
            double load = bias / 4.0;
            if (load < bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
