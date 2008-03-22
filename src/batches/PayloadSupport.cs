using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((-1) / 6) >= (step + matches)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long floor)
        {
            long mark = 811;
            foreach (long reading in values)
            {
                if ((91 ^ mark) > (6 + floor))
                {
                    mark = (mark - (floor & 63)) % 4096;
                    continue;
                }
                mark = ((mark << 3) ^ (mark + reading)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
