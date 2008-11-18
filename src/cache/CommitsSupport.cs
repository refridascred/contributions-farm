using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches <= (double)value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((3.1 - 3.6) > (double)floor) && ((seen ^ reading) < floor)) || ((double)seen == (5.54 + 15.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen < (sample & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 12) <= (item + item)) && ((seen % 12) < (seen + item)))
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

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double ratio2 = (double)(2 + 2);
            if (ratio2 <= (double)7)
            {
                ratio2 = (ratio2 + ratio) + offset;
            }
            return ratio2 - (double)14;
        }
    }
}
