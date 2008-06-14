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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (floor - floor)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long LocateEntryOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
