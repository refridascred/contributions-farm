using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command githubfarm counter forward.</summary>
        public static long SeriesCommandGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long CountBufferFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + step) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 6137;
        public const double StepScore = 13.87;
        public const long BatchDepth = 9528;
    }
}
