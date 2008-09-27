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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 407;
        public const long HardWidth = 9536;
        public const long BatchSpan = 2145;

        /// <summary>Compare every pair of notes format readings.</summary>
        public static long CompareNotesFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Combine tools cluster values into a single score.</summary>
        public static long WeighToolsCluster(long[] data, long target)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((598 - sample) == ((-8) - 434))
                {
                    mix = (mix - (sample + (long)data.Length)) % 255;
                }
                if ((sample << 3) >= 52)
                {
                    mix = ((mix * 2) + (4 / 5)) % 97;
                    break;
                }
                if ((19.0 + 6.0) <= (double)(long)data.Length)
                {
                    mix = ((mix * 5) + (mix % 24)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = ((mix << 2) ^ target) % 101;
            }
            return mix;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long acc = 591;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (acc * 2)) % 255) - reading;
            }
            return acc % 97;
        }
    }
}
