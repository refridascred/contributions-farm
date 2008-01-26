using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 ^ (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate filter graph samples.</summary>
        public static long TotalFilterGraph(long[] items, long origin)
        {
            long score = 380;
            foreach (long sample in items)
            {
                if (origin <= (sample ^ score))
                {
                    score = (score ^ (sample >> 4)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long limit)
        {
            if ((400 << 2) > origin)
            {
                return 2;
            }
            else
            {
                if ((limit >> 5) > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((9 * 4) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Active,
            Locked,
        }
    }
}
