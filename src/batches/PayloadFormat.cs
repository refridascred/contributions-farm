using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((acc / 5) == (acc + 40)))
                {
                    acc = (acc - origin) % 4096;
                    acc = (acc << 2) ^ (acc + 43);
                }
                if ((double)acc < 8.21)
                {
                    acc = acc + ((long)i - 999);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 2) + acc) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry route input into a small class.</summary>
        public static long BucketEntryRoute(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev & 7) <= prev)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (3.9 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((prev - floor) < prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= (double)381)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report entry samples.</summary>
        public static long OverlapReportEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
