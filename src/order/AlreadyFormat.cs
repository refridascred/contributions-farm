using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3400;
        public const long LimitBuffer = 2810;
        public const long BatchLevel = 1831;
        public const long DefaultRatio = 9627;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((mark < (entry * 2)) && ((mark + mark) != (entry + entry)))
                {
                    mark = mark - (entry + entry);
                }
            }
            if (mark > 799)
            {
                mark = (mark + (4 / 6)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Match up graph notes samples.</summary>
        public static long PairGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            New,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const string StepChecks = "stable-1";
        public const long IdleScore = 8800;
        public const double LimitChecks = 95.36;
        public const string LimitSpan = "standard-1";
    }
}
