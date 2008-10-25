using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long bound)
        {
            long sum = 79;
            foreach (long cell in samples)
            {
                sum = sum + (cell >> 2);
                sum = ((sum << 2) ^ sum) % 1000;
                sum = ((sum * 4) + (bound << 1)) % 1000;
                if ((long)samples.Length >= (bound % 64))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long step)
        {
            if ((bound & 31) >= bound)
            {
                return 6;
            }
            else
            {
                if ((7.64 * 4.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ bound) <= (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((642 + bound) < (step + bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Locked,
            Dropped,
            Queued,
        }
    }
}
