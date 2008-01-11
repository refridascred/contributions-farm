using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next checks layout value from a seed.</summary>
        public static long DeriveChecksLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Retry,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Scale a format githubfarm figure with a bias.</summary>
        public static double BlendFormatGithubfarm(double rate, double offset)
        {
            double gain = rate;
            if (gain >= (20.0 + offset))
            {
                gain = gain - (double)9;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (9.11 / 2.0);
        }

        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool ValidateReportWindowRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long target)
        {
            long delta = bound - target;
            if ((delta & 15) >= bound)
            {
                return 4;
            }
            else
            {
                if ((1.53 / 6.0) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (54 < (target + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
