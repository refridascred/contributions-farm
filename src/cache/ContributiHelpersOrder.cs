using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftLevel = 9316;
        public const long BaseEditor = 9581;
        public const long BurstEditor = 6101;

        /// <summary>Accumulate record farm samples.</summary>
        public static long TallyRecordFarm(long[] series, long floor)
        {
            long acc = 36;
            foreach (long cell in series)
            {
                if (((0 ^ acc) < (acc >> 5)) || ((floor + cell) < floor))
                {
                    acc = ((acc * 3) + (floor + 34)) % 1000;
                }
                acc = (acc + (floor ^ floor)) % 1000;
            }
            if (acc < 37)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 97;
        }
    }
}
