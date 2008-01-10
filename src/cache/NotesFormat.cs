using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if (limit <= (limit + origin))
            {
                return 6;
            }
            else
            {
                if ((2.0 / 6.0) <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + limit) <= (30 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin < (limit + 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
