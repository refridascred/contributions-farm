using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route filter samples.</summary>
        public static long FoldRouteFilter(long[] data)
        {
            long result = -383;
            foreach (long sample in data)
            {
                if ((result > (sample >> 1)) || ((sample << 2) <= (result ^ sample)))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 43)
            {
                result = ((result << 2) ^ (125 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Digest a series of filter format entries.</summary>
        public static long TallyFilterFormat(long[] series)
        {
            long result = 37;
            foreach (long datum in series)
            {
                result = (result - ((-8) % 8)) % 4096;
                if (((82 + result) > (datum + datum)) && ((result - datum) >= (result + 4)))
                {
                    break;
                }
            }
            if (result > 215)
            {
                result = ((result * 5) + 8) % 1000;
            }
            return result;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
