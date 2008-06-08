using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long OverlapSessionAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (6.04 * 14.0)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double ratio = (double)(40 + 4);
            if (ratio > (double)91)
            {
                ratio = (ratio + (double)7) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor * 5.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Compare every pair of account layout readings.</summary>
        public static long MatchAccountLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
