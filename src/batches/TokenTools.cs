using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long ScoreTokenNotes(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((sample + acc) == (sample + 9))
                {
                    acc = (acc - (2 * 5)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc % 60)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
