using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if ((result + (long)levels.Length) > 1)
                {
                    result = result ^ (cell & 255);
                    result = (result + (result + result)) % 255;
                }
                if (((result << 3) != (result + result)) && ((result + result) < (812 + cell)))
                {
                    result = (result << 2) ^ (cell << 1);
                }
            }
            return result;
        }
    }
}
