using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((62 ^ origin) < (661 + anchor))
                {
                    anchor = (anchor * 5) + (origin - (long)i);
                    anchor = (anchor * 5) + (origin % 97);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long CountNotesLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 5) > (reading + reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
