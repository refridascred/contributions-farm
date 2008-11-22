using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "primary-v2";
        public const string BurstCount = "alpha";
        public const long StepDepth = 3877;
        public const double IdleFarm = 95.06;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long mark = 607;
            foreach (long sample in items)
            {
                if (!((double)mark >= (double)sample))
                {
                    mark = ((mark + mark) % 1000) + seed;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
        }
    }
}
