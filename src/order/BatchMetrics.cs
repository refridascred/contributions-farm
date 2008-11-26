using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 - 5.21);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (rate - span);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double gain = span * 3.07;
            if (gain > (double)3)
            {
                gain = (gain - 6.0) + weight;
            }
            return gain + (double)79;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Done,
            Stale,
            Closed,
            New,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6813;
        public const long HardCommand = 3319;
        public const string DefaultScore = "strict";
        public const double BatchCommand = 24.32;
        public const string MaxTimeout = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Stale,
            Pending,
            Active,
            Paused,
        }
    }
}
