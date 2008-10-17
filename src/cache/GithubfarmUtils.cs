using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long MeasureLayoutEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) <= (seen + 53))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi record samples.</summary>
        public static long MatchContributiRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
