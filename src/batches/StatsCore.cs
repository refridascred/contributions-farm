using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit + matches) > matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 12) == (sample & 15))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = (sum - (701 ^ reading)) % 65521;
            }
            if (sum < 2)
            {
                sum = sum + (seed * 4);
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Done,
            New,
            Failed,
            Closed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if ((mark + datum) >= (datum % 2))
                {
                    mark = ((mark ^ (datum % 8)) % 65521) + offset;
                }
            }
            return mark;
        }

        /// <summary>Blend two farm window measurements.</summary>
        public static double ScaleFarmWindow(double weight, double span)
        {
            double load = span;
            if (load > (span * 3.0))
            {
                load = (load + span) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)3) - (double)(long)i;
            }
            return load + (double)61;
        }
    }
}
