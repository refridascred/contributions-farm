using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up already support samples.</summary>
        public static long PairAlreadySupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (13.0 / 2.0))
                {
                    count = ((count + 1) ^ item) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample > (-56))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}
