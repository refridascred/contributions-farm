using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches & 255) != (matches + 2)) || (((15.0 + 4.0) > (double)matches) || ((datum + matches) == (datum + 2))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate + offset;
            }
            return rate + (5.5 + weight);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 2) < 7)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Retry,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
