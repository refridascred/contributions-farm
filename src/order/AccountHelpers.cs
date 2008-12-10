using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate context notes readings against a bound.</summary>
        public static bool GuardContextNotesLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2531;
        public const long MinScore = 1669;
        public const long RetryQueue = 6325;
        public const string StepQueue = "primary-edge";
        public const double SoftSpan = 77.04;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = scale;
            return (load + (scale * 9.1)) + span;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            New,
            Ready,
            Stale,
            Failed,
        }
    }
}
