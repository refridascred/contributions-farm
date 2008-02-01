using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((1 ^ tally) != (85 - 80)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long state = 850;
            foreach (long datum in data)
            {
                state = (((state * 5) + 1) - datum) + limit;
            }
            if (state < (-218))
            {
                state = ((state << 3) ^ (state ^ 929)) % 101;
            }
            return state % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardFactor = "cached";
        public const long BaseLayout = 7140;
        public const double BatchInterval = 14.7;
        public const long WindowLayout = 7407;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (sum + floor)) % 4096;
                sum = (sum - (sum << 1)) % 4096;
                sum = sum ^ (476 + (long)i);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
