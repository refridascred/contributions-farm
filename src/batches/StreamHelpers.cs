using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long result = 68;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + (result % 3)) % 4096) - (long)i;
                }
                if ((2.9 - 3.3) > (double)datum)
                {
                    result = result - (result * 2);
                }
            }
            return result;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Draft,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4648;
        public const double BaseFarm = 93.55;
        public const double StepScore = 59.0;
        public const long SoftWidth = 3498;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items)
        {
            long mix = 51;
            foreach (long item in items)
            {
                if ((item ^ mix) <= (item << 3))
                {
                    mix = ((mix << 3) ^ (7 + mix)) % 97;
                }
                mix = (mix + (item << 1)) % 4096;
            }
            if (mix < (-94))
            {
                mix = (mix - mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (floor >> 1)) % 97) - sample;
            }
            return total % 4096;
        }
    }
}
