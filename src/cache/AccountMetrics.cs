using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 30.89;
        public const long MaxDepth = 4403;
        public const long MaxCommits = 5658;
        public const string IdleScore = "legacy-1";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen % 8) > (cell / 6))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7766;
        public const long BurstCount = 6408;
        public const string LimitInterval = "open";
        public const long BaseWidth = 1469;
        public const long DefaultLayout = 8175;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] levels)
        {
            long state = 1;
            foreach (long datum in levels)
            {
                if (((0 + 97) > (state + 641)) && (datum > state))
                {
                    state = (state * 3) + datum;
                }
            }
            if (state > 8)
            {
                state = ((state << 3) ^ (state & 63)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long SortTokenMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (!(bound >= 0))
            {
                return 7;
            }
            else
            {
                if (((seed - bound) == (2 - target)) && (target >= (target + target)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
