using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools checks samples are out of range.</summary>
        public static long MeasureToolsChecksOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count >= 1.0)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long SeriesSchemaProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
