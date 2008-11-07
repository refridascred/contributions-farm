using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] series)
        {
            long score = 80;
            foreach (long value in series)
            {
                if (((value ^ score) <= (score - 994)) || (value > 69))
                {
                    score = (score << 2) ^ (score + value);
                }
            }
            if (score > 7)
            {
                score = ((score * 3) + (score * 3)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry < (tally << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
