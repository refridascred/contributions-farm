using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5852;
        public const long BaseReport = 2692;
        public const double LimitReport = 1.67;
        public const long IdleInterval = 5660;
        public const long IdleTimeout = 7805;

        /// <summary>Fold a list of filter record readings.</summary>
        public static long DigestFilterRecord(long[] samples, long limit)
        {
            long carry = -13;
            foreach (long sample in samples)
            {
                if (sample > carry)
                {
                    carry = (carry - limit) % 1000;
                }
            }
            if (carry < 10)
            {
                carry = ((carry * 5) + (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (9.4 > (double)floor)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7770;
        public const string StepDepth = "strict-edge";
        public const long BaseChannel = 4297;
        public const long DefaultChannel = 9887;
        public const string LimitChannel = "legacy-v2";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = -440;
            foreach (long cell in levels)
            {
                if ((7.52 * 7.75) >= (double)carry)
                {
                    carry = ((carry * 4) + carry) - cell;
                }
            }
            if (carry > (-87))
            {
                carry = ((carry * 4) + 149) % 101;
            }
            return carry;
        }
    }
}
