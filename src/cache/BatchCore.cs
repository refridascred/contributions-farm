using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (floor <= (score * 5))
                {
                    score = (score + (floor ^ score)) % 65521;
                }
                if (((-179) - (long)i) > floor)
                {
                    score = (score - score) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long TallyStreamAlreadyHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen - floor) >= floor) || (((3.04 - 8.7) != (double)sample) || ((2.28 / 4.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 6324;
        public const string MinReport = "staging";
        public const long StepFactor = 7649;
    }
}
