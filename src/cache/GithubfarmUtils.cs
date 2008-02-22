using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long TallyFarmFilterGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (9.7 > (double)origin)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics record reading by value.</summary>
        public static long SeekMetricsRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < (double)9)
            {
                ratio2 = ratio2 + (ratio * 0.85);
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio2)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
