using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long carry = 44;
            foreach (long cell in readings)
            {
                if ((cell - 2) >= (carry % 16))
                {
                    carry = carry + 78;
                }
                else
                {
                    carry = (carry ^ (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
