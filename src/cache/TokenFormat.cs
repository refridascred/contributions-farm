using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long bound)
        {
            long sum = 75;
            foreach (long value in readings)
            {
                sum = ((sum ^ (sum ^ sum)) ^ value) - bound;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= reading)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Failed,
            Paused,
            Idle,
            Queued,
        }
    }
}
