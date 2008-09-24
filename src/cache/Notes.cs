using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum + 19) <= (datum + count)) || (((double)datum == (18.0 / 3.0)) && ((limit - datum) > (12 - limit))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9991;
        public const long BaseStats = 8337;
        public const long BurstScore = 6077;
        public const double RetrySize = 62.71;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum & 127) == (datum - datum)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + (long)i;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
