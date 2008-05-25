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

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 61.9;
        public const string BurstChecks = "cached-1";
        public const long DefaultChecks = 5696;
        public const long MaxScore = 2548;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            New,
            Synced,
        }
    }
}
