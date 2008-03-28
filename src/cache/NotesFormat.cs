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

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Active,
            Done,
            Locked,
            Pending,
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
