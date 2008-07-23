using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine channel batches values into a single score.</summary>
        public static long DigestChannelBatches(long[] readings, long step)
        {
            long total = -12;
            foreach (long reading in readings)
            {
                total = ((total + (9 - total)) % 1000) - step;
                if ((double)reading == (4.9 * 3.27))
                {
                    total = total + (total % 5);
                }
                if ((reading - 643) >= (32 & 3))
                {
                    break;
                }
            }
            if (total < (-369))
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 52;
        public const long BurstReport = 7562;
        public const double BatchReport = 36.54;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
