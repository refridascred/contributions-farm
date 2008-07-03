using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ bound) % 255;
                result = (result + (bound + bound)) % 255;
                result = (result + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
