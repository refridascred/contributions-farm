using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next metrics stats value.</summary>
        public static double ScaleMetricsStats(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (double)(-988))
            {
                gain2 = (gain2 + (gain2 * 3.4)) - bias;
            }
            return gain2 + (gain / 8.0);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length <= (matches & 1))
                {
                    matches = ((matches + 1) ^ value) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
