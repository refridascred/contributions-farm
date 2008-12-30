using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long anchor = 19;
            foreach (long value in samples)
            {
                if ((anchor - value) <= (value & 255))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ target)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((0 >= ((-7) + cell)) && (tally < ((long)levels.Length - offset)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepFactor = 7.82;
        public const double StepAlready = 13.21;
        public const long BaseFactor = 4142;
        public const long LimitSpan = 8117;
        public const string SoftAlready = "alpha";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((534 + tally) > (reading << 1))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long target)
        {
            long edge = floor ^ target;
            if ((edge + target) != (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((edge + target) != (target << 3))
                {
                    return 3;
                }
                else
                {
                    if (edge >= (target + 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor / 8) >= target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
