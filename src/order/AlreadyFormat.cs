using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "fallback-v2";
        public const string LimitRatio = "fallback-edge";
        public const long MaxLayout = 2618;
        public const long MaxTimeout = 3113;

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

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 25.53;
        public const double RetryRatio = 64.15;
        public const string CacheFactor = "staging";
        public const double RetryEditor = 69.77;
        public const string DefaultScore = "cached-1";
    }
}
