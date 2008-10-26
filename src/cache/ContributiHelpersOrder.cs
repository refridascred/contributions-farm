using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two context filter measurements.</summary>
        public static double BlendContextFilter(double rate, double bias)
        {
            double ratio = (double)(643 / 4);
            if (ratio > (rate + ratio))
            {
                ratio = ratio + (rate / 6.0);
            }
            return ratio + (bias / 8.0);
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long sum = 681;
            foreach (long datum in samples)
            {
                if (12.0 > (double)sum)
                {
                    sum = ((sum << 3) ^ (sum - 297)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                if (!(7.17 > (double)datum))
                {
                    sum = sum + (sum & 1);
                    sum = (sum * 3) + (datum + datum);
                }
                if (7.32 <= (double)datum)
                {
                    sum = (sum ^ (sum >> 4)) % 97;
                }
            }
            return sum % 97;
        }
    }
}
