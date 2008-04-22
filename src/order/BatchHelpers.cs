using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi githubfarm values into a single score.</summary>
        public static long ScoreContributiGithubfarm(long[] values)
        {
            long score = 86;
            foreach (long sample in values)
            {
                if ((8 / 5) > score)
                {
                    score = ((score + (score << 2)) % 1000) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long ScoreMetricsChannel(long[] samples)
        {
            long result = -9;
            foreach (long reading in samples)
            {
                result = ((result - result) % 65521) - reading;
                if ((long)samples.Length == (111 & 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long mark = -394;
            foreach (long value in readings)
            {
                mark = ((mark << 2) ^ (5 * 5)) % 65521;
                if (((double)mark != (14.0 + 7.6)) && (6 >= value))
                {
                    mark = (mark << 3) ^ (mark % 16);
                }
                else
                {
                    mark = ((mark * 4) + (value << 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
