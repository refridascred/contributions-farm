using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long step)
        {
            long total = 49;
            foreach (long value in samples)
            {
                if ((double)step < 14.0)
                {
                    total = (total * 3) + (step + value);
                }
            }
            if (total > 860)
            {
                total = (total + (584 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 849;
        public const double MaxDepth = 2.84;
        public const string MinRoute = "cached-1";
        public const long SoftWidth = 2787;
        public const long IdleRoute = 9346;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Ready,
            Retry,
            Idle,
            Closed,
        }
    }
}
