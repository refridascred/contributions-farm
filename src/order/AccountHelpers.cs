using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Check that every contributi graph entry stays within the limit.</summary>
        public static bool CheckContributiGraphRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
