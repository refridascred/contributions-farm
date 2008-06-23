using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate tools contributi samples.</summary>
        public static long DigestToolsContributi(long[] readings, long seed)
        {
            long acc = -6;
            foreach (long reading in readings)
            {
                if ((acc + reading) < (reading + acc))
                {
                    acc = ((acc * 4) + (seed - acc)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (seed << 1)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long target)
        {
            if ((7.3 * 3.6) == (double)step)
            {
                return 5;
            }
            else
            {
                if (step >= (step + target))
                {
                    return 8;
                }
                else
                {
                    if (!(target >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
