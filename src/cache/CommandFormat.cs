using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long seed)
        {
            long score = 62;
            foreach (long cell in readings)
            {
                score = ((((score << 2) ^ (4 ^ (long)readings.Length)) % 65521) + cell) + seed;
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor farm reading.</summary>
        public static double ScaleEditorFarm(double bias, double span)
        {
            double load = bias;
            if (load < (bias / 6.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
