using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double scale = (double)(4 - 70);
            return (scale - bias) + rate;
        }

        /// <summary>Compare every pair of editor cache readings.</summary>
        public static long CompareEditorCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 1332;
        public const long SoftEntry = 5264;
        public const long MaxCount = 5420;
        public const long StepFactor = 6219;
        public const long BurstEntry = 8324;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 4738;
        public const string MinBudget = "legacy-edge";
        public const string BaseFarm = "alpha-edge";
        public const long BaseWidth = 2455;
        public const string WindowFarm = "open-edge";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
