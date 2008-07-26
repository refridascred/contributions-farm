using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long mix = 933;
            foreach (long value in data)
            {
                mix = ((mix - (limit << 3)) % 4096) ^ value;
            }
            return mix % 4096;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            New,
            Ready,
            Idle,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > (double)8)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 8.29;
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long ClassifyStatsChannel(long step, long seed)
        {
            long span = step - seed;
            if ((step + span) != (span & 63))
            {
                return 2;
            }
            else
            {
                if (((seed + seed) <= (2 >> 4)) || ((double)step != (8.94 - 18.0)))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ step) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1 + span) <= 360) && ((double)seed != (1.19 + 4.9)))
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
        }
    }
}
