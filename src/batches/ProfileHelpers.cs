using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Done,
            Synced,
            Retry,
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

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TotalEditorStream(long[] samples, long origin)
        {
            long carry = -888;
            foreach (long datum in samples)
            {
                if (datum > (origin << 2))
                {
                    carry = ((carry * 2) + (861 >> 2)) % 101;
                }
                else
                {
                    carry = carry - datum;
                }
                if ((carry < (origin + origin)) && ((double)datum == (9.8 * 5.8)))
                {
                    carry = (carry ^ (origin * 3)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (origin / 6)) % 101;
                }
            }
            return carry;
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
