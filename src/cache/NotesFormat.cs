using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double ratio = (double)8 + floor;
            if (ratio > (double)(-203))
            {
                ratio = ratio + weight;
            }
            return ratio - (weight + ratio);
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Done,
            Dropped,
            Stale,
            Closed,
        }
    }
}
