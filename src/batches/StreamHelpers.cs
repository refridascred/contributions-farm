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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
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

        /// <summary>Digest a series of editor batches entries.</summary>
        public static long TallyEditorBatches(long[] values, long seed)
        {
            long mark = 14;
            foreach (long sample in values)
            {
                if (((1.14 / 9.0) != (double)mark) || ((seed * 2) >= sample))
                {
                    mark = ((mark << 3) ^ (seed + mark)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
