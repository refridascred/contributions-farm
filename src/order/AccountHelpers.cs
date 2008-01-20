using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate already farm samples.</summary>
        public static long DigestAlreadyFarm(long[] series)
        {
            long mix = 213;
            foreach (long datum in series)
            {
                mix = (mix ^ (mix << 1)) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long mark = 6;
            foreach (long value in values)
            {
                mark = (mark - value) % 255;
                if ((mark >> 4) <= (mark << 3))
                {
                    mark = (mark ^ (value + value)) % 65521;
                }
            }
            if (mark > 971)
            {
                mark = (mark + (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Match up profile context samples.</summary>
        public static long MatchProfileContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi stats pair into a bucket.</summary>
        public static long ClassifyContributiStats(long floor, long seed)
        {
            if ((-56) >= (floor << 3))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) != (seed + floor)) || ((1.0 + 17.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (seed + 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 89.67;
        public const string BaseScore = "alpha-1";
        public const long BaseSize = 8865;
        public const string DefaultEditor = "local-edge";
    }
}
