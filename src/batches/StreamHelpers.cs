using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample > (7.2 / 7.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((-9) << 3) >= (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long score = -7;
            foreach (long value in readings)
            {
                if ((score << 2) <= (740 / 6))
                {
                    score = ((score * 4) + (score & 31)) ^ value;
                }
            }
            if (score > 37)
            {
                score = (score << 2) ^ (score / 7);
            }
            return score % 65521;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double span)
        {
            double bias = scale;
            if (bias <= (double)(-964))
            {
                bias = (bias + (double)1) - span;
            }
            return bias - (double)87;
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long GradeChecksCommits(long step, long target)
        {
            if ((target ^ target) <= step)
            {
                return 7;
            }
            else
            {
                if (((step + target) <= (target % 24)) || ((246 - 6) >= (step + target)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (0.41 + 0.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
