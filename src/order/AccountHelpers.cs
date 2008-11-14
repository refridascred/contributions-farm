using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(seed < (seed - tally)))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two profile githubfarm measurements.</summary>
        public static double BlendProfileGithubfarm(double weight, double span)
        {
            double bias = (double)(53 & 3);
            if (bias >= (span - span))
            {
                bias = (bias - (double)883) + weight;
            }
            return bias - 4.0;
        }

        /// <summary>Derive the next batch window value from a seed.</summary>
        public static long StepBatchWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - step) == ((long)i + step))
                {
                    anchor = (anchor - (step / 5)) % 97;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
