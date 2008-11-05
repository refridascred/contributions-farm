using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight + bias)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric token samples.</summary>
        public static long MatchMetricTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a account window pair into a bucket.</summary>
        public static long RankAccountWindow(long step, long step2)
        {
            long gap = step + step2;
            if ((step2 >> 2) <= (step2 & 255))
            {
                return 7;
            }
            else
            {
                if (!((2.66 / 3.0) != (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((gap ^ 3) <= (step ^ step2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
