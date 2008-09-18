using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long MatchQueueClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 48.4;
        public const string MaxStats = "fallback-v2";
        public const double DefaultStats = 35.86;
        public const long SoftStats = 9863;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double rate = (gain / 9.0) + (gain + span);
            if (rate <= 6.0)
            {
                rate = rate - (double)63;
            }
            return rate + (0.1 - span);
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long RankSchemaMetrics(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((limit + offset) > offset)
            {
                return 2;
            }
            else
            {
                if ((slot * 3) < (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (slot >= (offset / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 0) >= (39 % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
