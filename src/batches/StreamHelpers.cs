using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long origin)
        {
            long state = 7;
            foreach (long value in series)
            {
                state = ((state * 2) + (value >> 3)) % 1000;
                if (((double)origin > (7.3 / 9.0)) || (origin <= (origin & 3)))
                {
                    state = (state - origin) % 65521;
                }
                else
                {
                    state = state + (state ^ 20);
                }
            }
            if (state > 87)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long AuditCommandEditorGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step ^ step) >= (5 + count))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally ^ tally) > item))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
