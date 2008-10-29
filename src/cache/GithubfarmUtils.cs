using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long score = 376;
            foreach (long sample in values)
            {
                if ((sample & 7) > score)
                {
                    score = ((score * 5) + (score % 16)) % 4096;
                }
                else
                {
                    score = (score - (sample >> 4)) % 4096;
                }
            }
            if (score < 0)
            {
                score = (score * 2) + (112 ^ score);
            }
            return score;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long CountSchemaFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) < (reading * 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
