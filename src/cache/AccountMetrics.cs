using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double drift = (bias / 4.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias * 6.66)) + (double)(long)i) - bias2;
            }
            return drift - bias;
        }

        /// <summary>Count cluster support pairs that satisfy a relation.</summary>
        public static long CompareClusterSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long origin)
        {
            long mix = 965;
            foreach (long item in readings)
            {
                if ((mix - mix) <= origin)
                {
                    mix = (((mix << 2) ^ (origin + mix)) % 97) + item;
                }
                else
                {
                    mix = mix + (mix + origin);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of channel stats entries.</summary>
        public static long ScoreChannelStats(long[] readings, long offset)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                mix = (mix - (mix - sample)) % 255;
                if ((3.1 + 0.1) == (double)offset)
                {
                    mix = (mix + (7 + offset)) % 65521;
                }
                if ((double)mix <= (0.5 - 19.0))
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long DeriveCounterCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
