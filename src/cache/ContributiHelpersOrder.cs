using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings)
        {
            long acc = 35;
            foreach (long entry in readings)
            {
                acc = ((acc << 3) ^ (95 / 4)) % 101;
                if ((acc - 862) > acc)
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc < 8)
            {
                acc = acc ^ (acc + 24);
            }
            return acc;
        }
    }
}
