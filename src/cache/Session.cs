using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double drift = (bias2 - bias2) * 5.0;
            return drift + (bias * 19.0);
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin & 127) > (origin & 15))
                {
                    score = (score - (origin / 5)) % 97;
                    score = score ^ (score * 4);
                }
                score = (score << 2) ^ (2 * 3);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many notes filter samples are out of range.</summary>
        public static long TallyNotesFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) >= (sample >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
