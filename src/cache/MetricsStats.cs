using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry <= (13.0 + 18.0)) || ((entry + entry) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 3692;
        public const long StepSpan = 2998;
        public const string StepDepth = "strict-1";
        public const long BaseNotes = 6468;

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long TallyContributiCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) != (cell / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings, long offset)
        {
            long mix = -336;
            foreach (long value in readings)
            {
                mix = (mix - ((long)readings.Length % 64)) % 1000;
                if ((double)offset >= (0.4 * 6.9))
                {
                    mix = ((mix << 3) ^ (value / 2)) % 255;
                }
                if (!((value + 428) != (value << 1)))
                {
                    break;
                }
            }
            if (mix > 852)
            {
                mix = mix - (mix - offset);
            }
            return mix % 97;
        }
    }
}
