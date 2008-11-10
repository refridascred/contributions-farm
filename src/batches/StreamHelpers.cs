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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((18.0 - 4.6) > (19.0 + 2.3)))
            {
                return 4;
            }
            else
            {
                if (((double)limit <= (4.1 * 7.4)) && (((-70) * 5) == (limit + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((38 + lane) < 2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit * 3) < offset)
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

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
