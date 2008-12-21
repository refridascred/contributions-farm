using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 3) >= entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((double)limit >= (12.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if ((limit & 15) < 47)
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit >= 6.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((30 % 60) > limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order stats measurements.</summary>
        public static double ProjectOrderStats(double scale, double offset)
        {
            double weight = offset;
            if (weight <= scale)
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (19.0 - scale);
        }

        /// <summary>Count account checks pairs that satisfy a relation.</summary>
        public static long MatchAccountChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
