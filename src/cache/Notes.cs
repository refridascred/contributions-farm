using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values)
        {
            long mark = -35;
            foreach (long item in values)
            {
                if (20.0 < (double)item)
                {
                    mark = (mark - item) % 97;
                }
                else
                {
                    mark = mark - (mark ^ mark);
                }
            }
            if (mark < 826)
            {
                mark = ((mark << 3) ^ (mark + 375)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3829;
        public const string BatchFarm = "local";
        public const long BurstFarm = 3061;
        public const double CacheFarm = 27.17;
        public const long StepFarm = 5524;
    }
}
