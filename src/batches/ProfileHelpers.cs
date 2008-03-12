using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - ((long)i + mark)) % 255;
                mark = (mark ^ (mark + target)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first layout profile entry that matches the target.</summary>
        public static long FindLayoutProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long CountCommandPayloadHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((52 + 49) >= count) && ((count >= (count / 9)) || ((count >> 1) < (count + item))))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
