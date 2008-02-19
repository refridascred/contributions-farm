using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                long edge = (limit % 8) & 63;
                if (((limit & 127) <= edge) || ((limit ^ limit) > (long)i))
                {
                    score = (score << 3) ^ (score << 3);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool CheckCommandToolsLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
