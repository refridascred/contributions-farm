using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long limit2)
        {
            if (!((double)limit > (double)limit2))
            {
                return 3;
            }
            else
            {
                if ((limit % 64) > 3)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long CountRecordAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step <= (count % 16))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a metrics batch sample.</summary>
        public static long LocateMetricsBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long state = -96;
            foreach (long item in data)
            {
                if (((73 - origin) > state) || ((item + 618) <= (item - item)))
                {
                    state = (state << 2) ^ (origin - state);
                }
                else
                {
                    state = state + (item + state);
                }
            }
            return state;
        }
    }
}
