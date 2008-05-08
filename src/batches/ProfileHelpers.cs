using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix / 7) > (7 * 4))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of contributi batches entries.</summary>
        public static long DigestContributiBatches(long[] data, long bound)
        {
            long result = 316;
            foreach (long sample in data)
            {
                result = (((result - result) % 1000) + sample) + bound;
            }
            if (result > 98)
            {
                result = (result + ((long)data.Length / 7)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long step)
        {
            if (((double)offset != (0.54 / 4.0)) && ((step >> 4) < (offset ^ step)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (4.88 + 4.2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series)
        {
            long total = 99;
            foreach (long sample in series)
            {
                if ((total + sample) <= (96 - total))
                {
                    total = (total - (sample / 6)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values, long limit)
        {
            long anchor = 3;
            foreach (long item in values)
            {
                if (!((double)(long)values.Length <= (double)item))
                {
                    anchor = ((anchor << 2) ^ limit) % 65521;
                }
            }
            return anchor;
        }
    }
}
