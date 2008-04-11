using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double load = scale;
            if (load <= scale)
            {
                load = load + offset;
            }
            return load - (double)807;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 8897;
        public const long CacheFactor = 8047;
        public const double MinSize = 50.09;
        public const double MaxTimeout = 24.14;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long step)
        {
            long delta = limit - step;
            if (delta > (-8))
            {
                return 0;
            }
            else
            {
                if (((-9) < (step / 4)) && ((14 & 3) > delta))
                {
                    return 1;
                }
                else
                {
                    if ((delta + delta) < (step + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Ready,
            Closed,
            Draft,
        }
    }
}
