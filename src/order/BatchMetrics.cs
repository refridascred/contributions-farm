using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) < (659 * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits channel entry stays within the limit.</summary>
        public static bool ValidateCommitsChannelBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((1 * 5) <= (cell - cell)) && ((311 & 31) >= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Retry,
            Closed,
        }
    }
}
