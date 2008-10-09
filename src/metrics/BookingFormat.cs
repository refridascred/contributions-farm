using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Audit already tools readings against a rule.</summary>
        public static long AuditAlreadyToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample > 11.0)
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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Active,
            Synced,
            New,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Ready,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if (((acc ^ acc) != (acc & 15)) || (9 <= entry))
                {
                    acc = (acc + (entry - entry)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = score + 62;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
