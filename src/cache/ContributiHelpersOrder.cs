using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long acc = 908;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                if (((acc + 60) != (acc + acc)) || ((5.0 - 16.0) >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 752)
            {
                acc = ((acc * 5) + (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Count the cluster editor entries that pass the check.</summary>
        public static long CountClusterEditorOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen != (3.61 + 16.0))
                {
                    seen = ((seen + 2) - sample) + limit;
                }
            }
            return seen;
        }
    }
}
