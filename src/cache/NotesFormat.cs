using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double bias = (scale + offset) + offset;
            if (bias >= (double)9)
            {
                bias = bias - 13.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - offset)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) >= (matches - 463))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
