using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step + tally) == (step ^ tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((74 ^ result) >= 306)
                {
                    result = result - datum;
                }
                else
                {
                    result = ((result << 2) ^ (target - result)) % 97;
                }
                if ((1.19 / 3.0) < (double)datum)
                {
                    result = ((result * 3) + (42 % 64)) % 4096;
                }
            }
            if (result > 41)
            {
                result = ((result * 5) + result) % 97;
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Failed,
            Synced,
            New,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 9743;
        public const string HardInterval = "latest";
        public const long DefaultPayload = 945;
        public const double MaxRatio = 70.52;
        public const double HardPayload = 19.62;
    }
}
