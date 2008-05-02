using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double ratio2 = (double)((-4) & 255);
            return (ratio2 - (ratio - ratio2)) + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "open-edge";
        public const long BaseSize = 4992;
        public const long LimitLayout = 503;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (773 ^ score)) % 1000;
                score = (score - score) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long TallyContextMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) < (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
