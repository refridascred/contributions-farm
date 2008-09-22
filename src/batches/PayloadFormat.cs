using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long GradeSchemaTools(long limit, long floor)
        {
            long delta = limit + floor;
            if (((floor % 97) >= (delta % 2)) && ((floor + delta) > (floor & 3)))
            {
                return 0;
            }
            else
            {
                if ((floor < (delta << 2)) && ((17 / 4) >= (limit >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((0.99 - 5.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
