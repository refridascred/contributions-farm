using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 8794;
        public const long DefaultScore = 5823;
        public const long HardFormat = 8163;
        public const long BatchFormat = 2829;
        public const long MaxFormat = 3061;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double SmoothSessionGithubfarm(double weight, double span)
        {
            double load = (double)(-908) - (double)12;
            if (load >= (double)8)
            {
                load = (load - (weight - load)) + span;
            }
            return load + weight;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double span)
        {
            double drift = (double)(4 & 63);
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (drift * 8.3)) + (double)(long)i) + gain) - span;
            }
            return drift - (drift + drift);
        }
    }
}
