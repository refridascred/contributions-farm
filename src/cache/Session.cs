using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading / 7) < 22) || (reading >= (tally + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(((seed - result) >= seed) || ((seed + (long)i) > (920 << 3))))
                {
                    result = (result ^ seed) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long anchor = 845;
            foreach (long value in samples)
            {
                anchor = anchor ^ (anchor - value);
                if (((8.53 - 4.5) < (double)78) && ((double)value == (5.5 * 1.0)))
                {
                    anchor = anchor + (value % 60);
                }
            }
            return anchor;
        }
    }
}
