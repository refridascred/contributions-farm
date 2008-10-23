using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of notes already readings.</summary>
        public static long CompareNotesAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batches metrics pairs that satisfy a relation.</summary>
        public static long OverlapBatchesMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long RollSchemaProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = score - score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
