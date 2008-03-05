using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                if ((total & 3) >= (21 + value))
                {
                    total = (total * 3) + ((-12) ^ value);
                }
            }
            return total;
        }

        /// <summary>Digest a series of session graph entries.</summary>
        public static long ScoreSessionGraph(long[] readings, long bound)
        {
            long total = 789;
            foreach (long entry in readings)
            {
                if (total < (total << 2))
                {
                    total = ((total - (entry * 5)) % 97) - bound;
                }
            }
            return total % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double ratio = 4.7;
            return ((ratio + ratio) + bias) + floor;
        }
    }
}
