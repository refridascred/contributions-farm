using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                long lane = total;
                if ((lane % 2) != (total ^ step))
                {
                    total = total + (step << 2);
                }
                else
                {
                    total = ((total * 3) + (8 - lane)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long RollMetricsRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next payload layout value from a seed.</summary>
        public static long SeriesPayloadLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((double)score < 5.0)
                {
                    score = score ^ (value + (long)readings.Length);
                }
            }
            return score;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Closed,
            Pending,
            Active,
        }
    }
}
