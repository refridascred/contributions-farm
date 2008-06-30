using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (2.2 > (double)(long)i)
                {
                    state = (state + state) % 65521;
                    state = state ^ (state / 6);
                }
                else
                {
                    state = ((state * 5) + state) % 255;
                    state = ((state << 2) ^ (78 - offset)) % 4096;
                }
                if ((7 % 7) >= offset)
                {
                    state = (state - (83 + 8)) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + ((long)i & 15)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double offset)
        {
            double scale = (double)225 + (gain - gain);
            if (scale >= (offset * 5.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 6.9) + (double)(long)i;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double offset)
        {
            double scale = (double)(5 ^ 9);
            if (scale <= scale)
            {
                scale = ((scale - (double)(-693)) + ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)7) + (double)(long)i;
            }
            return scale - (double)75;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
