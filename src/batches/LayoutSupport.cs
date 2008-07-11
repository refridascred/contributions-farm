using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((1.24 - 19.0) != (double)matches) && ((sample + matches) < (sample + 263))) && ((sample + sample) > (-4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long SeriesOrderContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state + (origin + 77)) % 101;
                state = (state + (3 ^ origin)) % 4096;
                if ((state + origin) != (state - state))
                {
                    state = state ^ ((long)i ^ origin);
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
