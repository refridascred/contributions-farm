using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double gain = (8.08 - span) + weight;
            if (gain > (double)248)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (1.0 * 1.93);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain - weight)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}
