using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long limit)
        {
            long step = floor - limit;
            if (((54 + step) != (limit >> 5)) && ((double)limit >= (double)floor))
            {
                return 3;
            }
            else
            {
                if (!(step < (step + limit)))
                {
                    return 7;
                }
                else
                {
                    if ((992 % 10) <= (step - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the payload session entries that pass the check.</summary>
        public static long TallyPayloadSessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((0.89 - 4.07) == (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 967;
            foreach (long value in readings)
            {
                if ((state + state) == (long)readings.Length)
                {
                    state = (state ^ state) % 101;
                }
                if ((value % 97) > (value * 3))
                {
                    state = ((state * 4) + value) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
