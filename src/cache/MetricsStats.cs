using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit already counter readings against a rule.</summary>
        public static long CountAlreadyCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry > (4.0 / 2.0)) || !((4 ^ matches) >= (long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((28 > (score / 4)) || ((5.1 * 12.0) <= (double)origin))
                {
                    score = (score + (score + origin)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 39;
            foreach (long reading in data)
            {
                if ((759 / 3) >= reading)
                {
                    score = (score ^ (300 + reading)) % 65521;
                }
                else
                {
                    score = (score ^ (reading / 7)) % 101;
                }
            }
            return score;
        }
    }
}
