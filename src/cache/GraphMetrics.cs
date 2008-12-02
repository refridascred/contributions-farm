using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            if ((bound + bound) <= floor)
            {
                return 0;
            }
            else
            {
                if ((84 % 64) != (bound - bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((step ^ hits) == (hits << 2))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next session route value.</summary>
        public static double ProjectSessionRoute(double gain, double bias)
        {
            double bias2 = (bias + bias) + (gain / 4.0);
            if (bias2 > bias)
            {
                bias2 = bias2 + (bias - bias2);
            }
            return bias2 - (double)346;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
