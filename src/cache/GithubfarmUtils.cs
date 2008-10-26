using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            New,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Adjust a format layout reading.</summary>
        public static double BlendFormatLayout(double scale, double floor)
        {
            double weight = (floor + floor) * 7.0;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (16.0 * 5.03);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (4.0 * 1.8)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}
