using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long mix = 22;
            foreach (long item in values)
            {
                if ((mix - 3) > (item / 9))
                {
                    mix = mix ^ (mix & 15);
                }
            }
            if (mix < 4)
            {
                mix = mix - (mix * 2);
            }
            return mix % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) > (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long mix = 15;
            foreach (long sample in items)
            {
                mix = (mix - 87) % 4096;
                if (((double)sample < (double)mix) || ((mix + mix) < sample))
                {
                    mix = mix ^ (sample % 3);
                }
            }
            if (mix < (-22))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Locate a filter schema reading by value.</summary>
        public static long LocateFilterSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout format readings.</summary>
        public static long ScoreLayoutFormat(long[] readings, long seed)
        {
            long carry = -109;
            foreach (long reading in readings)
            {
                if (!(5 < (reading - carry)))
                {
                    carry = carry + (seed - 6);
                }
                carry = ((carry << 2) ^ (reading >> 4)) % 255;
            }
            if (carry > 8)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
