using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if (step <= seed)
            {
                return 1;
            }
            else
            {
                if (step <= (829 & 127))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two format stream measurements.</summary>
        public static double ProjectFormatStream(double bias, double offset)
        {
            double gain = bias / 3.0;
            return gain + offset;
        }
    }
}
