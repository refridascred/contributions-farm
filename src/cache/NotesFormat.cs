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

        /// <summary>Blend two report window measurements.</summary>
        public static double BlendReportWindow(double ratio, double span)
        {
            double weight = ratio;
            if (weight < 7.4)
            {
                weight = weight + (ratio - span);
            }
            else
            {
                weight = weight - ratio;
            }
            return weight + (weight * 3.3);
        }
    }
}
