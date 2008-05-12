using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + ((long)i % 5)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((entry ^ (long)readings.Length) != (38 + entry)) && ((count >> 4) < entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 6412;
        public const long BaseLevel = 8850;
        public const long MinCount = 1107;
        public const string CacheCommand = "legacy-1";
        public const long BurstBudget = 3494;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
