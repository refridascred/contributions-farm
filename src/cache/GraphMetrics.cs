using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double weight = floor * 8.0;
            if (weight <= (bias / 8.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)963;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a checks editor reading by value.</summary>
        public static long LocateChecksEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell * 2) > ((-9) ^ hits)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
