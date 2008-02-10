using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mix = 645;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + sample) % 4096;
                if ((((-32) + sample) != (sample ^ 81)) && (5.5 <= (double)sample))
                {
                    mix = (mix - 1) % 101;
                }
            }
            if (mix < (-19))
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 961;
            foreach (long sample in values)
            {
                if ((double)sum > (1.0 - 9.4))
                {
                    sum = sum - (sample / 2);
                }
            }
            return sum;
        }
    }
}
