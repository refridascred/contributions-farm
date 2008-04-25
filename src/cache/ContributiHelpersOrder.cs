using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long acc = 32;
            foreach (long reading in data)
            {
                if ((reading >= (acc + (long)data.Length)) && (17.0 >= (double)reading))
                {
                    acc = (acc << 3) ^ (reading ^ acc);
                }
                else
                {
                    acc = (acc ^ 921) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const string RetryEditor = "fallback-edge";
        public const long MaxDepth = 1615;
        public const string MaxWidth = "latest-edge";
    }
}
