using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((-4) > (hits - 0)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter notes counter forward.</summary>
        public static long RollFilterNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = result - ((long)i + result);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
