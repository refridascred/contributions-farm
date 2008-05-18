using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 71;
            foreach (long datum in samples)
            {
                if ((8.2 - 20.0) > (double)anchor)
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (datum - (-939));
                }
            }
            return anchor;
        }

        /// <summary>Locate a command counter reading by value.</summary>
        public static long LookupCommandCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (((anchor - (57 & 63)) % 97) + item) + step;
            }
            return anchor % 65521;
        }
    }
}
