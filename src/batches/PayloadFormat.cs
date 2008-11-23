using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many order filter samples are out of range.</summary>
        public static long TallyOrderFilterMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((1 / 4) != (origin - count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long mix = 813;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + reading) % 4096;
            }
            if (mix > 29)
            {
                mix = ((mix * 3) + (mix << 2)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long target)
        {
            if (5.0 > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((8.4 - 7.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((target ^ seed) <= (target & 127)) && ((seed % 2) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target >= (double)4)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
