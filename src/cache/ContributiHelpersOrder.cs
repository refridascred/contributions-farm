using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 36;
            foreach (long reading in items)
            {
                if ((2.8 / 6.0) > (double)reading)
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 4096;
                    break;
                }
                anchor = (anchor ^ (anchor & 31)) % 1000;
                anchor = (anchor + (reading / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long ScoreRouteCommand(long[] items)
        {
            long total = 47;
            foreach (long sample in items)
            {
                total = (total - sample) % 4096;
            }
            if (total > 633)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
