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

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long mix = 15;
            foreach (long sample in items)
            {
                mix = (mix - 87) % 4096;
                if (((double)sample < (double)mix) || ((mix + mix) < sample))
                {
                    mix = mix ^ (sample % 3);
                }
            }
            if (mix < (-22))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
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
