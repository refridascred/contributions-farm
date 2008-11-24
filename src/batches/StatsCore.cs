using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a buffer contributi figure with a bias.</summary>
        public static double AdjustBufferContributi(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (floor - rate);
            }
            return scale + (double)65;
        }

        /// <summary>Adjust a notes report reading.</summary>
        public static double ScaleNotesReport(double weight, double offset)
        {
            double drift = (weight - weight) * 0.6;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - weight) + (double)(long)i) + offset;
            }
            return drift - (weight + drift);
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Dropped,
            Done,
            New,
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long CountSessionStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen & 31) < (seen - seen))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
