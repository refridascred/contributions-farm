using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long step, long target)
        {
            if ((250 - target) > ((-234) * 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of session filter readings.</summary>
        public static long FoldSessionFilter(long[] samples)
        {
            long result = 40;
            foreach (long entry in samples)
            {
                result = (result + entry) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen ^ (long)readings.Length))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double bias, double span)
        {
            double drift = bias + (double)72;
            if (drift >= (bias / 7.0))
            {
                drift = drift + 8.4;
            }
            else
            {
                drift = drift + (drift * 9.8);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (drift * 3.0);
        }

        /// <summary>Roll a stats cache counter forward.</summary>
        public static long SeriesStatsCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (limit - state)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
