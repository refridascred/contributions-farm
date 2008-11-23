using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            if (((offset >> 2) > (7 + 6)) && ((origin % 2) > (17 - origin)))
            {
                return 8;
            }
            else
            {
                if (offset >= (25 + origin))
                {
                    return 2;
                }
                else
                {
                    if (!((offset / 2) > (origin << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = (double)(573 >> 3);
            return ((mean - (5.77 * 6.41)) + scale) + span;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            New,
            Retry,
            Draft,
            Dropped,
        }
    }
}
