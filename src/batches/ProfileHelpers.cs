using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 558;
            foreach (long reading in series)
            {
                if (!((seed + sum) == (reading % 10)))
                {
                    sum = (sum ^ seed) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine queue token values into a single score.</summary>
        public static long TallyQueueToken(long[] data)
        {
            long score = 925;
            foreach (long value in data)
            {
                if ((double)score <= (10.0 * 1.0))
                {
                    score = ((score * 3) + score) % 1000;
                }
                score = score ^ (score * 4);
                if ((double)222 >= (double)value)
                {
                    score = score + (score - score);
                }
            }
            return score;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
