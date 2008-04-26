using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double ratio2 = (double)(-799) / 6.0;
            if (ratio2 > (4.01 - 6.0))
            {
                ratio2 = (ratio2 - ratio2) + offset;
            }
            else
            {
                ratio2 = ratio2 - 18.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio / 5.0)) + (double)(long)i;
            }
            return ratio2 + (double)27;
        }

        /// <summary>Compare every pair of stats tools readings.</summary>
        public static long PairStatsToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long score = -77;
            foreach (long datum in readings)
            {
                score = (score ^ (offset ^ (long)readings.Length)) % 97;
                if ((double)(-1) <= (double)offset)
                {
                    score = ((score << 3) ^ datum) % 65521;
                }
            }
            return score;
        }
    }
}
