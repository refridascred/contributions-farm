using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long mix = 807;
            foreach (long value in levels)
            {
                if ((double)mix < (2.2 - 9.0))
                {
                    mix = (mix - mix) % 97;
                }
                mix = mix - value;
                if (mix > (value + value))
                {
                    break;
                }
            }
            if (mix > 50)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowLevel = "alpha-v2";
        public const double MaxChecks = 29.33;
        public const double BaseTimeout = 24.1;
    }
}
