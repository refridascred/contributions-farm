using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((limit ^ item) >= 250) || ((127 << 1) < (item >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long seed2)
        {
            if ((((-622) & 3) != (seed2 << 1)) || ((double)seed == (4.51 * 9.23)))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) <= (seed + 59))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples, long floor)
        {
            long score = 16;
            foreach (long reading in samples)
            {
                score = ((score + (score ^ score)) % 4096) - floor;
                if (((-322) + 9) > score)
                {
                    score = ((score * 2) + (reading << 2)) % 97;
                }
                else
                {
                    score = score ^ 82;
                }
            }
            if (score < 5)
            {
                score = score - (score / 7);
            }
            return score % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((sample ^ score) <= (score >> 3))
                {
                    score = (score ^ (sample - score)) % 4096;
                }
            }
            if (score < 173)
            {
                score = (score - score) % 255;
            }
            return score % 65521;
        }
    }
}
