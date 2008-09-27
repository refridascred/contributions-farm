using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = floor * 1.47;
            if (rate <= (gain / 6.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - 9.43)) + (double)(long)i;
            }
            return rate - (double)86;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + score) < (score / 6))
                {
                    score = score ^ (step + 5);
                }
                score = (score - score) % 101;
                score = score ^ (step / 7);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 21;
            foreach (long cell in data)
            {
                if ((7.6 > (double)cell) && (((-391) >> 2) < (anchor ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ cell) % 65521;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor % 4096;
        }
    }
}
