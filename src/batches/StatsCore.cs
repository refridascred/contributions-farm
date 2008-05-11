using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (long)i) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double rate = offset - gain;
            return rate + rate;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (bound ^ anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits > ((long)readings.Length ^ hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples, long origin)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if ((double)carry > (19.0 / 6.0))
                {
                    carry = ((carry * 4) + (38 + 0)) % 1000;
                }
                else
                {
                    carry = (carry ^ 70) % 1000;
                }
                if ((carry * 5) == (entry / 7))
                {
                    carry = carry + entry;
                }
                else
                {
                    carry = ((carry * 3) + (carry >> 5)) % 4096;
                }
                if ((entry ^ 58) > origin)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "stable-v2";
        public const double BatchScore = 77.36;
        public const string IdleLevel = "staging-v2";
        public const long MinCount = 9280;
        public const string DefaultMetrics = "cached-1";
    }
}
