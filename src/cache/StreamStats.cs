using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long score = 15;
            foreach (long datum in levels)
            {
                if ((score / 3) == (datum / 8))
                {
                    score = (score + (datum + score)) % 4096;
                }
            }
            if (score < (-347))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long MatchToolsSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session graph value.</summary>
        public static double SmoothSessionGraph(double rate, double offset)
        {
            double load = rate + rate;
            if (load >= (load / 8.0))
            {
                load = load - load;
            }
            else
            {
                load = load - (offset / 8.0);
            }
            return load - load;
        }
    }
}
