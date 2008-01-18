using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally * 3) >= (541 - sample))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long target)
        {
            long mark = 2;
            foreach (long reading in samples)
            {
                mark = ((mark - (target - mark)) % 4096) + reading;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next support editor value from a seed.</summary>
        public static long DeriveSupportEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if ((result / 4) >= (step ^ step))
                {
                    result = (result - step) % 65521;
                }
                result = (result ^ (step % 10)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
