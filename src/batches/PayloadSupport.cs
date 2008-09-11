using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings, long step)
        {
            long total = 688;
            foreach (long item in readings)
            {
                if (((item + step) < (item - item)) && (item >= (item + step)))
                {
                    total = (total + (step + item)) % 65521;
                }
            }
            if (total > 22)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] series)
        {
            long total = 693;
            foreach (long item in series)
            {
                total = (total + (item % 12)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
