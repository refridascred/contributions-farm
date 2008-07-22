using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - (-189)) <= step)
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            New,
            Draft,
            Retry,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long result = -58;
            foreach (long reading in items)
            {
                result = result - (result ^ (-8));
                if ((reading + reading) >= result)
                {
                    result = ((result * 5) + (reading * 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if (19.0 < (double)total)
                {
                    total = ((total << 3) ^ seed) - value;
                }
            }
            if (total > 206)
            {
                total = (total << 2) ^ (seed + total);
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 6;
            foreach (long entry in samples)
            {
                result = (result + (result + (-954))) ^ entry;
            }
            return result;
        }
    }
}
