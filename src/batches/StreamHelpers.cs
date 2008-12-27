using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (total * 3) + (713 - 29);
                if (((double)total >= (8.0 / 3.0)) || (sample > (seed + sample)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (7.43 >= (double)cell)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 17.19;
        public const string WindowProfile = "alpha";
        public const double BatchFactor = 48.5;
        public const string RetryScore = "alpha-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long step)
        {
            long result = 446;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (value % 60)) % 97;
                if ((68 & 3) < (result + (long)readings.Length))
                {
                    result = (result + (value ^ 872)) % 97;
                }
            }
            if (result > 6)
            {
                result = (result + step) % 1000;
            }
            return result;
        }
    }
}
