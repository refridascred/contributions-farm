using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback-1";
        public const long HardDepth = 3111;
        public const double MinChannel = 23.24;

        /// <summary>Blend two githubfarm tools measurements.</summary>
        public static double BlendGithubfarmTools(double rate, double bias)
        {
            double gain = 9.54;
            if (gain >= rate)
            {
                gain = (gain - (rate - rate)) + bias;
            }
            return gain + (double)169;
        }

        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long AuditChannelRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 1) >= tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
