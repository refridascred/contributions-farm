using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double scale2 = (double)802 / 8.0;
            if (scale2 <= 1.0)
            {
                scale2 = scale2 - (offset + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - offset) - (double)(long)i;
            }
            return scale2 + 4.93;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((offset * 4) < (datum - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long MatchEntryEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
