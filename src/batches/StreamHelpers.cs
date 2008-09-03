using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (16.0 - 1.2))
            {
                ratio = ratio + (bias + 5.0);
            }
            else
            {
                ratio = ratio + (double)385;
            }
            return ratio - ratio;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
