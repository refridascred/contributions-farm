using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long carry = 62;
            foreach (long reading in series)
            {
                if ((double)reading >= 2.64)
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
                if ((carry / 4) <= origin)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 69) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the account editor entries that pass the check.</summary>
        public static long CountAccountEditorHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((773 + seed) == ((long)readings.Length ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
