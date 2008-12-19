using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values)
        {
            long sum = 7;
            foreach (long datum in values)
            {
                if ((sum & 15) < (6 - sum))
                {
                    sum = ((sum << 2) ^ sum) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report githubfarm readings against a bound.</summary>
        public static bool VerifyReportGithubfarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double AdjustNotesCluster(double ratio, double floor)
        {
            double rate = (double)(87 + 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (floor * 12.0)) - (double)(long)i) - ratio;
            }
            return rate + floor;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
