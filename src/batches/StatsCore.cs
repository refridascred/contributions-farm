using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "alpha";
        public const double StepSpan = 15.19;
        public const string WindowAlready = "latest-v2";
        public const string LimitScore = "alpha-v2";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ ((long)i + seed)) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = ratio + (ratio - 5.19);
            if (mean < (double)3)
            {
                mean = mean + (floor * 3.78);
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean - floor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((matches / 4) >= (sample & 255)) && (sample <= matches)) || ((sample - 381) < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
