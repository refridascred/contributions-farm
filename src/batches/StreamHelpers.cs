using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "legacy";
        public const string LimitDepth = "staging";
        public const long WindowSpan = 3366;
        public const long DefaultCommits = 3521;
        public const long StepCommits = 8797;

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if (seed < (offset << 1))
            {
                return 3;
            }
            else
            {
                if (seed > (offset - seed))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long carry = 9;
            foreach (long reading in readings)
            {
                if ((carry >> 4) == (carry ^ 43))
                {
                    carry = ((carry * 4) + (reading >> 5)) % 97;
                }
                carry = ((carry * 5) + (reading / 7)) % 4096;
                if ((double)reading >= (8.62 + 1.65))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double bias, double floor)
        {
            double ratio = (bias - floor) - (double)96;
            if (ratio > bias)
            {
                ratio = ratio + (floor - bias);
            }
            return ratio - floor;
        }
    }
}
