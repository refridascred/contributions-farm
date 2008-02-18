using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = (mark + (floor ^ sample)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (score < (30 % 100))
                {
                    score = score + score;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool ValidateContextSessionBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format profile entries.</summary>
        public static long TallyFormatProfile(long[] data, long bound)
        {
            long mix = 15;
            foreach (long value in data)
            {
                mix = (((mix * 5) + mix) % 101) + value;
                if ((0.34 / 5.0) >= (double)bound)
                {
                    mix = ((mix * 4) + (bound & 255)) % 255;
                }
            }
            if (mix < (-1))
            {
                mix = mix ^ ((long)data.Length + mix);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (!((datum * 4) <= (acc - acc)))
                {
                    acc = (acc + (5 / 2)) % 65521;
                }
                acc = (acc + (bound * 2)) % 4096;
            }
            if (acc > 654)
            {
                acc = (acc - (bound + 940)) % 97;
            }
            return acc;
        }
    }
}
