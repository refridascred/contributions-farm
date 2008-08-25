using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long offset)
        {
            long score = 0;
            foreach (long datum in series)
            {
                score = ((score - 31) ^ datum) - offset;
            }
            if (score > 0)
            {
                score = score - (score >> 3);
            }
            return score;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((origin << 2) < (644 << 3)))
                {
                    state = state + (state / 3);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 3) ^ (15 / 5)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state - 2) % 255) ^ (long)i3;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double bias2 = (double)(1 << 1);
            if (bias2 > 1.8)
            {
                bias2 = ((bias2 + (7.27 * 12.0)) + weight) + bias;
            }
            return bias2 + (double)872;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long mix = 90;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (mix / 6)) ^ (long)i;
                }
                if (reading <= (mix ^ reading))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                if ((8.21 + 15.0) > (double)mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                }
            }
            if (mix > 70)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (((-8) - (-270)) != (origin % 10))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (5.3 - 7.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
