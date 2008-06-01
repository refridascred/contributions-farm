using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Measure how many session counter samples are out of range.</summary>
        public static long MeasureSessionCounterHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample - (long)series.Length) != (seen / 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
