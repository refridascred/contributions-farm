using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample < (96 << 3)) && (hits >= ((long)readings.Length - sample))) || ((floor ^ hits) < (sample - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Done,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double bias = (span - 4.63) * 9.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)(long)i) + rate;
            }
            return bias + span;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
