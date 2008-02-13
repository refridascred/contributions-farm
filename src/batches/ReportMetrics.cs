using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine profile batch values into a single score.</summary>
        public static long TotalProfileBatch(long[] readings, long step)
        {
            long score = 34;
            foreach (long datum in readings)
            {
                score = (score - datum) % 97;
            }
            if (score < 94)
            {
                score = (score - (step << 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = (result << 2) ^ result;
                if ((result / 9) == (sample ^ sample))
                {
                    result = result - sample;
                }
                else
                {
                    result = ((result << 3) ^ (result & 1)) % 4096;
                }
                if (((double)step > (11.0 + 8.2)) && (sample <= (step + step)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
