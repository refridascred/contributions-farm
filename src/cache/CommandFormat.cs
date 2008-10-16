using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long RankSchemaEntry(long offset, long step)
        {
            if ((7 + step) <= offset)
            {
                return 7;
            }
            else
            {
                if ((step / 5) < 6)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 1952;
        public const long RetryRatio = 2471;
        public const long IdleLevel = 407;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = (result - result) ^ cell;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }
    }
}
