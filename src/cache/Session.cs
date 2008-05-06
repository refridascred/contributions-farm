using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels)
        {
            long mix = 95;
            foreach (long value in levels)
            {
                mix = mix + (mix % 16);
                if ((value >> 3) == (mix - mix))
                {
                    mix = (mix - mix) % 101;
                }
                if ((value < 0) && ((value - mix) == (19 & 15)))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 3161;
        public const long CacheLevel = 7354;
        public const string IdleCommits = "legacy-1";
        public const double MinCommits = 28.27;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long floor)
        {
            long mix = 666;
            foreach (long datum in samples)
            {
                mix = (mix ^ (datum + (-9))) % 97;
                if (floor > (mix + datum))
                {
                    mix = mix + floor;
                }
            }
            if (mix > 691)
            {
                mix = (mix - (floor - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
