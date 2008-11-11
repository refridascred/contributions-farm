using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of notes record entries.</summary>
        public static long DigestNotesRecord(long[] samples)
        {
            long result = 613;
            foreach (long sample in samples)
            {
                result = (result - sample) % 255;
            }
            if (result > (-648))
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((seed * 4) != (seed >> 1))
            {
                return 0;
            }
            else
            {
                if ((seed % 10) > 83)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) > 14)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
