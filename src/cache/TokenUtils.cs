using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)cell >= 12.0)
                {
                    anchor = (anchor * 3) + ((-700) ^ 27);
                }
            }
            if (anchor < 641)
            {
                anchor = anchor ^ (269 + anchor);
            }
            return anchor % 4096;
        }
    }
}
