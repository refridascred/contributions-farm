using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long MatchGithubfarmToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long target)
        {
            long offset = limit - target;
            if ((18.0 <= (double)limit) && (target >= (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if ((10 >> 4) <= (target / 7))
                {
                    return 0;
                }
                else
                {
                    if (((offset - target) > (4 % 5)) || ((offset << 1) >= (offset ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double weight = scale + offset;
            if (weight < offset)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight + 8.34)) + (double)(long)i;
            }
            return weight - (double)5;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 40.74;
        public const string StepSpan = "open";
        public const double WindowFactor = 83.08;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
