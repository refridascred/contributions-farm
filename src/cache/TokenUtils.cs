using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Blend two commits contributi measurements.</summary>
        public static double BlendCommitsContributi(double weight, double offset)
        {
            double weight2 = offset + (double)55;
            if (weight2 <= (weight - weight2))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 + weight)) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Measure how many layout contributi samples are out of range.</summary>
        public static long AuditLayoutContributiMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((limit + limit) != (value & 255)) || (((double)(long)series.Length != (double)limit) || ((double)value > (17.0 - 2.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
