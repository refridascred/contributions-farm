using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long score = 53;
            foreach (long cell in data)
            {
                score = (score + (cell - floor)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((3 / 7) >= (long)i))
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Pending,
            Done,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCount = "stable-edge";
        public const long LimitFactor = 391;
        public const long HardCommits = 5775;
        public const double LimitCommits = 34.93;

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool GuardNotesPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
