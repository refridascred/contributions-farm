using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long bound)
        {
            if ((1.0 <= (double)bound) || ((bound << 1) == (bound * 5)))
            {
                return 2;
            }
            else
            {
                if ((5 + bound) > (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if ((5.2 - 5.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound >> 4) <= bound) || ((1.1 * 2.3) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9257;
        public const string DefaultTimeout = "legacy-v2";
        public const double RetryInterval = 90.94;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TallyCommandFarm(long[] series)
        {
            long result = 530;
            foreach (long reading in series)
            {
                if ((98 > ((long)series.Length + 6)) && ((54 << 1) >= result))
                {
                    result = (result ^ (reading * 2)) % 65521;
                }
                else
                {
                    result = (result + (reading + 50)) % 1000;
                }
                if (((double)result != (10.0 / 8.0)) && (((-22) & 1) >= (result % 16)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 63.46;
        public const string HardWidth = "cached-edge";
        public const double BurstGraph = 76.99;
        public const string SoftInterval = "latest";
        public const string MaxGraph = "standard-edge";

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
