using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Roll a layout tools counter forward.</summary>
        public static long DeriveLayoutTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(step <= mix))
                {
                    mix = mix + ((long)i << 2);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Grade a batch already value against two limits.</summary>
        public static long RankBatchAlready(long bound, long limit)
        {
            if ((bound + bound) < bound)
            {
                return 3;
            }
            else
            {
                if (limit > bound)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) >= 30)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + bound) < (1 - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
