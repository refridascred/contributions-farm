using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long StepBufferStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
                result = (result + (9 / 7)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Dropped,
            New,
            Synced,
            Closed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long target)
        {
            long mark = -41;
            foreach (long sample in values)
            {
                if (((sample / 4) > (mark - sample)) || ((109 ^ 888) < target))
                {
                    mark = (mark - (target + sample)) % 4096;
                }
                else
                {
                    mark = (mark + mark) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)target == (18.0 + 0.3)) && (cell > (count + 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up channel report samples.</summary>
        public static long CompareChannelReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 88.44;
        public const double StepBudget = 20.96;
        public const string MinRatio = "latest";
        public const long DefaultTools = 2925;
        public const string SoftTimeout = "local";
    }
}
