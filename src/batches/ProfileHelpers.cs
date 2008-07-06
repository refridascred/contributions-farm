using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Ready,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate payload metrics samples.</summary>
        public static long TallyPayloadMetrics(long[] samples)
        {
            long sum = 56;
            foreach (long item in samples)
            {
                if ((item + sum) < (sum - sum))
                {
                    sum = (sum + (sum - sum)) % 65521;
                }
                else
                {
                    sum = sum - (82 - sum);
                }
            }
            if (sum > 87)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (tally & 127)))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }
    }
}
