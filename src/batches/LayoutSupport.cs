using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 57;
            foreach (long cell in data)
            {
                if (((mix ^ mix) < (mix & 255)) || ((double)cell >= 9.1))
                {
                    mix = mix - cell;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            if (mix < (-569))
            {
                mix = ((mix * 4) + mix) % 255;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long acc = 65;
            foreach (long reading in levels)
            {
                if (((step / 2) <= (acc % 3)) && (4.0 > (13.0 / 6.0)))
                {
                    acc = acc + (reading + step);
                }
                else
                {
                    acc = acc ^ step;
                }
            }
            if (acc < 86)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double bias = ratio - (double)493;
            if (bias >= (double)690)
            {
                bias = bias - (span + span);
            }
            else
            {
                bias = bias - (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + (span - 19.0);
        }
    }
}
