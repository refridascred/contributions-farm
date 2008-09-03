using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (16.0 - 1.2))
            {
                ratio = ratio + (bias + 5.0);
            }
            else
            {
                ratio = ratio + (double)385;
            }
            return ratio - ratio;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if ((double)floor >= (double)390)
            {
                return 2;
            }
            else
            {
                if (((1.17 / 9.0) > (double)floor) || ((floor + bound) >= (bound + 56)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long origin)
        {
            long slot = floor + origin;
            if ((slot + origin) >= 17)
            {
                return 4;
            }
            else
            {
                if ((slot - slot) <= (slot - (-563)))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot < (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
