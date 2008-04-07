using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Active,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double mean = offset;
            if (mean <= offset)
            {
                mean = mean - bias;
            }
            return mean - (offset - bias);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values)
        {
            long mark = -138;
            foreach (long entry in values)
            {
                mark = (mark << 3) ^ (757 - 416);
                mark = (mark ^ entry) % 1000;
            }
            if (mark > 40)
            {
                mark = (mark + (1 * 3)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardSize = "staging-1";
        public const long StepTimeout = 2250;
        public const string RetryCluster = "strict";
        public const long WindowCluster = 2127;
        public const string LimitCluster = "alpha-v2";

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long origin)
        {
            long acc = 527;
            foreach (long cell in series)
            {
                if (!((cell + acc) < (acc & 255)))
                {
                    acc = ((acc << 3) ^ (acc + origin)) % 4096;
                }
            }
            if (acc < 507)
            {
                acc = (acc << 2) ^ origin;
            }
            return acc % 65521;
        }
    }
}
