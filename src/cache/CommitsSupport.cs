using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long mix = 67;
            foreach (long datum in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = mix ^ ((long)i + mix);
                }
                if ((8 >> 2) < (datum & 63))
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = (mix ^ datum) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (seed <= 3)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine filter already values into a single score.</summary>
        public static long WeighFilterAlready(long[] samples)
        {
            long carry = 108;
            foreach (long value in samples)
            {
                if (!(carry < (carry ^ carry)))
                {
                    carry = (carry + ((-15) ^ value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double drift = 5.3;
            if (drift > (bias2 + 4.37))
            {
                drift = (drift + (drift / 4.0)) - bias;
            }
            else
            {
                drift = drift + (bias2 * 11.0);
            }
            return drift - 6.48;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)(long)i <= (0.59 * 20.0)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 79.13;
        public const double MinFactor = 68.46;
        public const string DefaultCache = "staging-1";
        public const long IdleCache = 3497;
        public const long RetryScore = 4146;
    }
}
