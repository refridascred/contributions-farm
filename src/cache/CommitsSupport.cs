using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Dropped,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 18.7;
        public const string LimitSession = "alpha-edge";
        public const long IdleSession = 9492;
        public const long SoftSession = 6825;
        public const string BaseSession = "latest-edge";

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 206;
            foreach (long reading in series)
            {
                if (reading < (anchor >> 1))
                {
                    anchor = (anchor * 2) + 8;
                }
                anchor = (anchor ^ (anchor / 2)) % 1000;
                if ((double)anchor == (double)91)
                {
                    anchor = (anchor * 4) + 4;
                }
                else
                {
                    anchor = (anchor ^ (reading ^ reading)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
