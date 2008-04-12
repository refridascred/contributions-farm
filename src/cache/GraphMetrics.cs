using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (((bound + bound3) < (bound3 >> 1)) && ((bound2 & 63) == (bound3 * 4)))
            {
                return 0;
            }
            else
            {
                if ((94 * 4) < (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound != (8.0 / 3.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long offset)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if ((89 + sample) > acc)
                {
                    acc = (acc ^ (618 + 19)) - offset;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((88 - seen) < (seen * 5))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowBudget = 17.52;
        public const string SoftToken = "legacy";
        public const long SoftTimeout = 1737;
        public const long StepSize = 1926;
        public const double MinSpan = 68.78;

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long MatchEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
