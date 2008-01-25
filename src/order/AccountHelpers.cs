using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long ClassifyCommitsMetric(long offset, long limit)
        {
            long delta = offset - limit;
            if ((0.3 / 4.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((delta % 12) != (offset % 3)) || ((limit ^ delta) <= (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 100) <= (delta >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - offset) <= (593 - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 955;
            foreach (long reading in series)
            {
                if ((reading - 91) > (anchor - reading))
                {
                    anchor = (anchor << 3) ^ (-37);
                }
                else
                {
                    anchor = anchor + 2;
                }
                if (anchor > reading)
                {
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long carry = 140;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ (carry + carry)) ^ datum;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)floor >= 4.4)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command contributi readings.</summary>
        public static long ScoreCommandContributi(long[] items)
        {
            long anchor = 30;
            foreach (long cell in items)
            {
                anchor = (anchor + (83 / 9)) - cell;
            }
            if (anchor < 600)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
