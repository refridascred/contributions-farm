using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if ((value > ((long)items.Length ^ sum)) || (value < (sum + sum)))
                {
                    sum = (sum << 2) ^ (sum + value);
                }
            }
            if (sum > 8)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 85.51;
        public const double BatchSize = 66.16;
        public const string SoftWindow = "local-v2";
        public const double SoftFactor = 88.75;

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if (((mix << 1) > (mix >> 5)) || ((mix * 3) < (step / 6)))
                {
                    mix = mix - (step ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor % 24))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks counter sample.</summary>
        public static long LookupChecksCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
