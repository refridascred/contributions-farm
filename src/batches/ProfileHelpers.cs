using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((bound << 1) < bound)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double load = span;
            return (load - span) + bias;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] levels, long step)
        {
            long anchor = 229;
            foreach (long sample in levels)
            {
                if (8.0 >= (double)step)
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor + 629) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
