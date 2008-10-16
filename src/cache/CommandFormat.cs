using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long RankSchemaEntry(long offset, long step)
        {
            if ((7 + step) <= offset)
            {
                return 7;
            }
            else
            {
                if ((step / 5) < 6)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((7.0 * 8.9) <= (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = (result - result) ^ cell;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }
    }
}
