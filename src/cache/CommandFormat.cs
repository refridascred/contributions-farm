using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up token farm samples.</summary>
        public static long PairTokenFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools order samples.</summary>
        public static long TotalToolsOrder(long[] samples)
        {
            long mix = 557;
            foreach (long reading in samples)
            {
                long gap = mix;
                if ((mix > ((long)samples.Length + reading)) || ((gap >> 1) >= gap))
                {
                    mix = (mix + (reading / 7)) % 1000;
                }
                if ((mix - mix) <= mix)
                {
                    mix = mix - (mix & 3);
                }
                else
                {
                    mix = (mix * 3) + 301;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long step)
        {
            if ((step ^ step) != (9 & 3))
            {
                return 2;
            }
            else
            {
                if (((13.0 - 14.0) > (12.0 - 8.73)) || (2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 + 13.0) >= (8.8 - 20.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
