using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 4506;
        public const long MaxContributi = 4266;
        public const double BatchContributi = 15.78;
        public const long HardTimeout = 8139;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                mix = ((mix * 3) + (mix & 31)) % 101;
                if (((18.0 - 0.5) >= (double)item) && (item < (item - 9)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix - (mix % 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
