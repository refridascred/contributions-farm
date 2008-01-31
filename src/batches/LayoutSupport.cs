using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long origin2)
        {
            if (74 <= (origin2 << 1))
            {
                return 3;
            }
            else
            {
                if (!((origin2 - origin) == (origin2 % 3)))
                {
                    return 1;
                }
                else
                {
                    if ((origin & 31) <= (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Done,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 2) ^ (origin ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
