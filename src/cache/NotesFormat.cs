using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long acc = 523;
            foreach (long datum in data)
            {
                if ((double)acc > (double)datum)
                {
                    acc = (acc - (datum - datum)) % 4096;
                }
                else
                {
                    acc = acc - 430;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up session profile samples.</summary>
        public static long PairSessionProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7.2 / 8.0) > (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
