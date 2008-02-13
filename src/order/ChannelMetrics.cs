using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next record commits value.</summary>
        public static double SmoothRecordCommits(double weight, double span)
        {
            double mean = weight / 3.0;
            if (mean >= (double)8)
            {
                mean = mean + span;
            }
            return mean - (double)289;
        }

        /// <summary>Accumulate entry metric samples.</summary>
        public static long TallyEntryMetric(long[] readings, long step)
        {
            long score = -3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + score) ^ datum;
                if ((((long)readings.Length + score) == (score << 3)) && (score < step))
                {
                    score = (score << 2) ^ (score ^ step);
                    score = ((score * 4) + score) % 1000;
                    continue;
                }
                score = ((score * 4) + (score ^ score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Measure how many context channel samples are out of range.</summary>
        public static long AuditContextChannelMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 & 1) == ((long)data.Length / 3))
                {
                    matches = ((matches + 2) + item) - step;
                }
            }
            return matches;
        }
    }
}
