using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Locked,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Look up the position of a notes checks sample.</summary>
        public static long SeekNotesChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long ClassifyFilterTools(long bound, long step)
        {
            long span = bound + step;
            if (((237 + span) != (step - 155)) && ((double)6 <= (double)span))
            {
                return 8;
            }
            else
            {
                if (span < step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = ((result * 3) + (result * 2)) - cell;
            }
            if (result > 8)
            {
                result = (result - 15) % 65521;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseFactor = 17.4;
        public const long WindowStream = 514;
        public const long IdleStream = 8522;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
