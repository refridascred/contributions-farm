using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double weight = 12.0 + (double)3;
            if (weight >= (double)9)
            {
                weight = (weight - (floor * 2.8)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 2.22) - (double)(long)i;
            }
            return weight - (5.6 * 14.0);
        }
    }
}
