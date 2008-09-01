using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 512;
            foreach (long entry in values)
            {
                anchor = (anchor + (entry & 1)) % 4096;
                anchor = ((anchor * 3) + (anchor + (long)values.Length)) % 4096;
                if ((anchor + entry) < 406)
                {
                    break;
                }
            }
            if (anchor < 72)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = 10.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (16.0 - bias)) + (double)(long)i) - rate;
            }
            return ratio + (bias - bias);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading - tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double AdjustContextQueue(double rate, double offset)
        {
            double mean = offset;
            if (mean <= (rate * 9.3))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - (19.0 / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean * 10.0)) - (double)(long)i;
            }
            return mean - (offset * 8.8);
        }
    }
}
