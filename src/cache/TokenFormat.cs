using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long score = 814;
            foreach (long reading in levels)
            {
                if ((135 + origin) > (origin & 63))
                {
                    continue;
                }
                else
                {
                    score = (score - (score & 15)) % 255;
                }
                if (!(reading >= (29 >> 5)))
                {
                    score = (score ^ (reading / 8)) % 101;
                }
                if ((17.0 / 4.0) >= (double)reading)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long carry = 725;
            foreach (long datum in data)
            {
                if ((datum + limit) != (datum >> 1))
                {
                    carry = ((carry * 4) + (datum & 15)) % 1000;
                }
            }
            if (carry > (-171))
            {
                carry = (carry - (carry << 2)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Stale,
            Done,
            Locked,
        }
    }
}
