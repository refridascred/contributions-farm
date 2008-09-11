using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long OverlapSupportFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long WeighGraphReport(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                if ((1.0 / 4.0) >= (double)result)
                {
                    result = (result - result) % 65521;
                    result = (result * 3) + result;
                }
                if (!((cell ^ cell) >= cell))
                {
                    result = (result + (cell / 2)) % 1000;
                }
                if (result >= (61 + cell))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((-79) <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSize = 3504;
        public const long HardGithubfarm = 8470;
        public const long MaxScore = 4495;
        public const long HardSpan = 9457;
    }
}
