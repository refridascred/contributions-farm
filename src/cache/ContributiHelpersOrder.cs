using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples, long step)
        {
            long score = 20;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length - 5) >= (0 + (long)samples.Length)) || (((long)samples.Length >> 1) == ((long)samples.Length << 1)))
                {
                    score = ((score ^ (score + score)) % 1000) ^ datum;
                }
                if ((step << 3) < (score + step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up graph cluster samples.</summary>
        public static long OverlapGraphClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
