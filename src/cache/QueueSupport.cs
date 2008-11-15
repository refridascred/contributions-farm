using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double weight = span - (double)373;
            if (weight < 4.22)
            {
                weight = weight + (double)808;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Active,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 7074;
        public const double SoftCount = 64.84;
        public const long WindowOrder = 9305;
    }
}
