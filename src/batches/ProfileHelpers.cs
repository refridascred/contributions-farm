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

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                acc = ((acc * 3) + (acc + entry)) + seed;
            }
            return acc;
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

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
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
