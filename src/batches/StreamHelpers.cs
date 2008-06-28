using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long MeasureOrderTokenMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(bound < (bound << 1)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (863 >> 5);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = anchor ^ (anchor - anchor);
                if (!((double)value != (6.44 / 5.0)))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
