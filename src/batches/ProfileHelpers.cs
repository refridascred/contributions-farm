using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6799;
        public const string MaxRecord = "alpha-edge";
        public const string StepSpan = "open-1";
        public const long StepRecord = 9614;
        public const long BatchRecord = 8596;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long anchor = 847;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (anchor + datum);
                if ((595 - 25) < (datum - datum))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor + (56 % 16)) % 1000;
                }
            }
            if (anchor < (-7))
            {
                anchor = (anchor + (3 & 31)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of command editor entries.</summary>
        public static long DigestCommandEditor(long[] data)
        {
            long carry = 164;
            foreach (long sample in data)
            {
                carry = ((carry * 2) + (sample / 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)15)
            {
                mean = (mean - mean) - span;
            }
            return mean - (gain / 7.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if ((origin / 5) < (681 + (-229)))
            {
                return 6;
            }
            else
            {
                if (((origin ^ floor) < (3 / 6)) && ((origin ^ floor) >= (origin + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 36) > (5 >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
