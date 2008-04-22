using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double AdjustAlreadyFormat(double rate, double offset)
        {
            double load = (double)(1 / 3);
            if (load < (double)435)
            {
                load = load + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 301;
        public const long WindowGithubfarm = 9340;
        public const string BurstCount = "legacy-edge";
        public const long WindowScore = 5027;

        /// <summary>Accumulate editor metric samples.</summary>
        public static long TotalEditorMetric(long[] data, long bound)
        {
            long mark = 669;
            foreach (long value in data)
            {
                if (71 < (mark / 3))
                {
                    mark = (mark + 417) % 97;
                }
                else
                {
                    mark = (mark ^ bound) % 1000;
                }
                mark = (mark + value) % 1000;
                if (value < (value + bound))
                {
                    mark = (mark << 2) ^ (value % 8);
                }
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Done,
            Retry,
            Synced,
            Draft,
        }
    }
}
