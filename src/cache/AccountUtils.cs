using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of graph tools entries.</summary>
        public static long FoldGraphTools(long[] series)
        {
            long score = -12;
            foreach (long value in series)
            {
                score = (score << 2) ^ (value + score);
                if (!((score + score) >= (value << 1)))
                {
                    score = (score + (value + 8)) % 97;
                }
            }
            if (score < 7)
            {
                score = (score ^ (score / 8)) % 97;
            }
            return score;
        }
    }
}
