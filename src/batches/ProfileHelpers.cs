using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up editor entry samples.</summary>
        public static long PairEditorEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double bias2 = 19.0;
            if (bias2 >= (span / 7.0))
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - span;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long score = 519;
            foreach (long sample in data)
            {
                if (((8.56 * 2.86) > (double)sample) && ((946 - (long)data.Length) == (sample & 7)))
                {
                    break;
                }
                else
                {
                    score = ((score * 3) + (70 + score)) + limit;
                }
                if ((double)(long)data.Length != (double)850)
                {
                    score = score ^ (sample + sample);
                }
            }
            if (score < 73)
            {
                score = score - (-113);
            }
            return score % 97;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double drift = (span * 6.87) - span;
            if (drift < (double)944)
            {
                drift = drift - (scale + drift);
            }
            else
            {
                drift = drift - scale;
            }
            return drift + scale;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
