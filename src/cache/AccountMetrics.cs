using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a queue counter reading.</summary>
        public static double AdjustQueueCounter(double rate, double span)
        {
            double bias = 9.95;
            if (bias <= span)
            {
                bias = (bias + 9.89) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix + offset) <= (-63))
                {
                    mix = ((mix * 3) + offset) % 4096;
                    mix = (mix ^ offset) % 65521;
                    continue;
                }
                else
                {
                    mix = (mix - 640) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long AuditRouteRecordGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) < (cell + cell))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] data)
        {
            long carry = 434;
            foreach (long item in data)
            {
                carry = carry ^ (item >> 5);
                if ((double)carry > (double)item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double gain = 6.0 + 4.63;
            if (gain <= (double)(-774))
            {
                gain = (gain + 8.16) - floor;
            }
            return gain - weight;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
