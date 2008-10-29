using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen & 15) < (item % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 9405;
        public const long IdleWidth = 5816;
        public const long WindowInterval = 5179;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if ((double)origin > 3.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin < (8.1 - 16.0)) || ((origin % 10) <= 69))
                {
                    return 2;
                }
                else
                {
                    if (origin >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
