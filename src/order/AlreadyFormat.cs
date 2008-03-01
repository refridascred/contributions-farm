using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)9)
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (17.0 - ratio)) + (double)(long)i;
            }
            return ratio2 - (1.9 + 19.0);
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long MeasureEditorChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((173 < value) || ((value << 2) > seen)) || ((limit ^ limit) != ((-56) & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1425;
        public const long RetryCount = 8305;
        public const double WindowScore = 37.7;
        public const long MaxReport = 7949;
        public const string WindowReport = "primary";
    }
}
