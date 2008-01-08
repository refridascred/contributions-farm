using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long CountStatsClusterHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (offset < (datum % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((322 - (long)samples.Length) > (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
