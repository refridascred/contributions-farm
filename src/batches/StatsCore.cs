using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if (score < (step << 2))
                {
                    score = (score ^ ((long)i << 2)) % 101;
                }
                else
                {
                    score = (score + ((long)i * 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((9 ^ floor) > (floor ^ value)) || ((tally >> 2) == (floor - 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Closed,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)979)
            {
                weight = weight - (8.0 * 18.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (span - 1.12);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((4.2 + 2.7) < (double)seen) && ((double)seen > (1.71 * 6.0))))
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
