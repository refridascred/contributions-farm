using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long mix = 2;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + value) + (long)i;
                }
                if (((15.0 / 9.0) < (double)mix) || (57 > (value + value)))
                {
                    mix = (mix << 2) ^ value;
                }
                else
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
            }
            if (mix < 72)
            {
                mix = (mix - (mix * 4)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = -205;
            foreach (long sample in levels)
            {
                if ((sample / 3) == (592 ^ sample))
                {
                    total = (total << 3) ^ 6;
                }
                else
                {
                    total = (total ^ (23 & 255)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count & 1) > (7 + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long MeasureCacheCommandHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count & 31) <= (datum - bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
