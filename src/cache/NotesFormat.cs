using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample > (sample - tally)) && ((double)(long)data.Length <= (8.09 + 0.4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long seed)
        {
            long result = 46;
            foreach (long datum in readings)
            {
                result = ((result * 2) + seed) % 1000;
                if ((double)datum > (double)seed)
                {
                    result = result ^ (seed & 15);
                }
                result = result - (seed + 0);
            }
            return result % 4096;
        }

        /// <summary>Derive the next metric editor value from a seed.</summary>
        public static long RollMetricEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((-795) - (long)i) >= (mark + mark))
                {
                    mark = mark + (offset % 16);
                    mark = (mark << 3) ^ offset;
                }
                mark = mark ^ (mark - (long)i);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
