using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally > value)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch support entries.</summary>
        public static long TallyBatchSupport(long[] series)
        {
            long mix = -7;
            foreach (long reading in series)
            {
                if ((double)mix != (16.0 + 8.0))
                {
                    mix = (mix * 2) + (mix + mix);
                }
                else
                {
                    mix = (mix - (853 - mix)) % 4096;
                    mix = mix - (reading - reading);
                }
                mix = mix ^ mix;
                if ((reading * 3) < (58 % 24))
                {
                    mix = (mix << 3) ^ 6;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 5) + (mix + 72)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data)
        {
            long acc = 414;
            foreach (long value in data)
            {
                acc = ((acc << 2) ^ (72 + value)) % 255;
            }
            if (acc < 174)
            {
                acc = ((acc * 4) + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
