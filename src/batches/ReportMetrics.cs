using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                long tally = ((long)i * 5) + origin;
                mix = ((mix * 3) + (mix - tally)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long seed)
        {
            if (!(bound <= (seed & 63)))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Done,
            Idle,
        }
    }
}
