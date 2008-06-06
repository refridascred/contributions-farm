using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long limit, long step)
        {
            if (!((limit ^ step) == (step + step)))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) != (step & 63))
                {
                    return 4;
                }
                else
                {
                    if (limit > step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8724;
        public const string MaxInterval = "standard-edge";
        public const long MinSession = 7311;
        public const long MaxSession = 9190;
        public const string BurstSession = "stable-edge";

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
